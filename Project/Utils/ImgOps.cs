using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;

using System.Windows.Forms;

namespace Project
{
    class ImgOps
    {
        public static Mat RGBtoHSV(Mat img)
        {
            Mat tmp = new Mat();
            try
            {
                Emgu.CV.Image<Bgr, Byte> image = img.ToImage<Bgr, Byte>();
                Bitmap b = image.ToBitmap();
                Emgu.CV.Image<Hsv, Byte> imgHsv = new Image<Hsv, Byte>(b);
                tmp = imgHsv.Mat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tmp;

        }
        public static Image<Gray, Byte> RGBtoGrey(Mat img)
        {
            Image<Gray, Byte> grayImage = new Image<Gray, byte>(new Size(0,0));
            try
            {
                Emgu.CV.Image<Bgr, Byte> image = img.ToImage<Bgr, Byte>();
                grayImage = image.Convert<Gray, Byte>();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return grayImage;
        }
        public static Mat toBinary(Mat img, int threshold, int maxValue)
        {
            Mat tmp = new Mat();
            try
            {
                tmp = ImgOps.RGBtoGrey(img).Mat;
                CvInvoke.Threshold(tmp, tmp, threshold, maxValue,0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tmp;
        }

        public static Mat InterpolationResize(Mat img, int w, int h)
        {
            try
            {
                CvInvoke.Resize(img, img, new Size(w, h), (double)Inter.Cubic);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return img;
        }

        public static Mat ContrastAlignment(Image<Gray, Byte> img)
        {
            Mat result = new Mat();
            CvInvoke.CLAHE(img, 4, new Size(16, 16), result);
            return result;
        }

        public static Image<Gray, Byte> RGBFilter(Image<Hsv, Byte> input, double Hmin, double Hmax, double Smin, double Smax, double Vmin, double Vmax)
        {
            Bitmap b = input.Bitmap;
            Hsv lowerLimit = new Hsv(Hmin, Smin, Vmin);
            Hsv upperLimit = new Hsv(Hmax, Smax, Vmax);
            Image<Gray, byte> result = input.InRange(lowerLimit, upperLimit);
            
            return result;
        }

        public static Image<Bgr, Byte>  makeSmooth(Image<Bgr, Byte> input, Size size, int sigmaX, int sigmaY)
        {
            CvInvoke.GaussianBlur(input, input, size, sigmaX, sigmaY);
            return input;
        }
        public static Image<Gray, Byte> makeSmooth(Image<Gray, Byte> input, Size size, int sigmaX, int sigmaY)
        {
            CvInvoke.GaussianBlur(input, input, size, sigmaX, sigmaY);
            return input;
        }
        public static Image<Hsv, Byte> makeSmooth(Image<Hsv, Byte> input,Size size, int sigmaX, int sigmaY)
        {
            CvInvoke.GaussianBlur(input, input, size, sigmaX, sigmaY);
            return input;
        }
        public static Image<Bgr, byte> cannydetect(Image<Bgr, byte> img)
        {
            Mat src = img.Mat;

            Mat gray = new Mat();

            CvInvoke.CvtColor(src, gray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            Mat edges = new Mat();

            CvInvoke.Canny(gray, edges, 60, 60 * 3);
            Image<Bgr, byte> res = new Image<Bgr, byte>(edges.Bitmap);
            return res;
        }
    }
}
