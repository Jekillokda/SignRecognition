using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace Project
{
    class ShapeDetection
    {
            public ShapeDetection()
            {}

            static public Image<Bgr,byte> detectShape(Image<Bgr, byte> imgInput)
            {
                if (imgInput == null)
                {
                    return imgInput;
                }

                try
                {
                    var temp = imgInput.SmoothGaussian(9).Convert<Gray, byte>().ThresholdBinaryInv(new Gray(230), new Gray(255));

                    VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                    Mat m = new Mat();

                    CvInvoke.FindContours(temp, contours, m, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                    for (int i = 0; i < contours.Size; i++)
                    {
                        double perimeter = CvInvoke.ArcLength(contours[i], true);
                        VectorOfPoint approx = new VectorOfPoint();
                        CvInvoke.ApproxPolyDP(contours[i], approx, 0.04 * perimeter, true);

                        CvInvoke.DrawContours(imgInput, contours, i, new MCvScalar(0, 0, 255), 2);

                        //moments  center of the shape

                        var moments = CvInvoke.Moments(contours[i]);
                        int x = (int)(moments.M10 / moments.M00); 
                        int y = (int)(moments.M01 / moments.M00);

                        if (approx.Size == 3)
                        {
                            CvInvoke.PutText(imgInput, "Triangle", new Point(x, y),
                                Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(0, 0, 255), 2);
                        }

                        if (approx.Size == 4)
                        {
                            Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);

                            double ar = (double)rect.Width / rect.Height;

                            if (ar >= 0.95 && ar <= 1.05)
                            {
                                CvInvoke.PutText(imgInput, "Square", new Point(x, y),
                                Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(0, 0, 255), 2);
                            }
                            else
                            {
                                CvInvoke.PutText(imgInput, "Rectangle", new Point(x, y),
                                Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(0, 0, 255), 2);
                            }

                        }

                        if (approx.Size == 6)
                        {
                            CvInvoke.PutText(imgInput, "Hexagon", new Point(x, y),
                                Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(0, 0, 255), 2);
                        }


                        if (approx.Size > 6)
                        {
                            CvInvoke.PutText(imgInput, "Circle", new Point(x, y),
                                Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(0, 0, 255), 2);
                        }

                        return imgInput;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            return imgInput;
            }

       static public Image<Bgr,byte> detectShape2(Image<Bgr, byte> imgInput, int drawtag)
        { 
         //Convert the image to grayscale and filter out the noise
         UMat uimage = new UMat();
         Image<Bgr, byte> result = imgInput;
         CvInvoke.CvtColor(imgInput, uimage, ColorConversion.Bgr2Gray);

         //use image pyr to remove noise
         UMat pyrDown = new UMat();
         CvInvoke.PyrDown(uimage, pyrDown);
         CvInvoke.PyrUp(pyrDown, uimage);

         #region circle detection
         double cannyThreshold = 180.0;
         double circleAccumulatorThreshold = 120;
         CircleF[] circles = CvInvoke.HoughCircles(uimage, HoughType.Gradient, 85, 20.0, cannyThreshold, circleAccumulatorThreshold, 10, 100);

         #endregion

         #region Canny and edge detection
         double cannyThresholdLinking = 120.0;
         UMat cannyEdges = new UMat();
         CvInvoke.Canny(uimage, cannyEdges, cannyThreshold, cannyThresholdLinking);

         LineSegment2D[] lines = CvInvoke.HoughLinesP(
            cannyEdges,
            2, //Distance resolution in pixel-related units
            Math.PI / 45.0, //Angle resolution measured in radians.
            20, //threshold
            30, //min Line width
            10); //gap between lines

         #endregion

         #region Find triangles and rectangles
         List<Triangle2DF> triangleList = new List<Triangle2DF>();
         List<RotatedRect> boxList = new List<RotatedRect>();

         using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
         {
             CvInvoke.FindContours(cannyEdges, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
             int count = contours.Size;
             for (int i = 0; i < count; i++)
             {
                 using (VectorOfPoint contour = contours[i])
                 using (VectorOfPoint approxContour = new VectorOfPoint())
                 {
                     CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);
                     if (CvInvoke.ContourArea(approxContour, false) > 250) //only consider contours with area greater than 250
                     {
                         if (approxContour.Size == 3) //The contour has 3 vertices, it is a triangle
                         {
                             Point[] pts = approxContour.ToArray();
                             triangleList.Add(new Triangle2DF(
                                pts[0],
                                pts[1],
                                pts[2]
                                ));
                         }
                         else if (approxContour.Size == 4) //The contour has 4 vertices.
                         {
                             #region determine if all the angles in the contour are within [80, 100] degree
                             bool isRectangle = true;
                             Point[] pts = approxContour.ToArray();
                             LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                             for (int j = 0; j < edges.Length; j++)
                             {
                                 double angle = Math.Abs(
                                    edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                                 if (angle < 80 || angle > 100)
                                 {
                                     isRectangle = false;
                                     break;
                                 }
                             }
                             #endregion
                             if (isRectangle) boxList.Add(CvInvoke.MinAreaRect(approxContour));
                         }
                     }
                 }
             }
         }

            #region draw lines
            if (drawtag == 1 || (drawtag == 5))
            {
                foreach (LineSegment2D line in lines)
                    result.Draw(line, new Bgr(Color.Green), 5);
            }
            #endregion

            #endregion
            #region draw triangles
            if ((drawtag == 2 || (drawtag == 5)))
            {
                foreach (Triangle2DF triangle in triangleList)
                 result.Draw(triangle, new Bgr(Color.DarkBlue), 5);
            }
            #endregion

            #region draw rectangles
            if ((drawtag == 3 || (drawtag == 5)))
            {
                foreach (RotatedRect box in boxList)
                    result.Draw(box, new Bgr(Color.DarkOrange), 5);
            }
            #endregion

           /* #region draw circles
            if ((drawtag == 4 || (drawtag == 5)))
            {
                foreach (CircleF circle in circles)
                    result.Draw(circle, new Bgr(Color.Brown), 5);
            }
            #endregion*/
         return result;
     }
    }
}
