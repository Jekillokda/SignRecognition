using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public static Mat RGBtoGrey(Mat img)
        {
            Mat tmp = new Mat();
            try
            {
                Emgu.CV.Image<Bgr, Byte> image = img.ToImage<Bgr, Byte>();
                Image<Gray, Byte> grayImage = image.Convert<Gray, Byte>();
                tmp = grayImage.Mat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tmp;
        }
        public static Mat Resize(Mat img, int h, int w)
        {
            try
            {
                CvInvoke.Resize(img, img, new Size(h, w));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return img;
        }

        public static Hsv GetHSV(Color color)
        {
            Hsv res = new Hsv();

            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            res.Hue = Math.Round(color.GetHue(), 2);
            res.Satuation = ((max == 0) ? 0 : 1d - (1d * min / max)) * 100;
            res.Satuation = Math.Round(res.Satuation, 2);
            res.Value = Math.Round(((max / 255d) * 100), 2);

            return res;
        }

        public static Image<Gray, Byte> RGBFilter(Image<Hsv, Byte> input, double Hmin, double Hmax, double Smin, double Smax, double Vmin, double Vmax)
        {
            Bitmap b = input.Bitmap;
            Hsv lowerLimit = new Hsv(Hmin, Smin, Vmin);
            Hsv upperLimit = new Hsv(Hmax, Smax, Vmax);
            /*for (int x = 0; x < input.Width; x++)
            {
                for(int y = 0; y < input.Height; y++)
                {
                    Color c = b.GetPixel(x, y);
                    Hsv pix = ImgOps.GetHSV(c);
                    if ((pix.Hue>Hmin)&& (pix.Hue < Hmax)&& (pix.Satuation > Smin)&& (pix.Satuation < Smax)&& (pix.Value > Vmin)&& (pix.Value < Vmax))
                    {
                        b.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        b.SetPixel(x, y, Color.Black);
                    }
                }
            }*/
            //Image<Gray, byte> result = new Image<Gray, byte>(b);
            Image<Gray, byte> result = input.InRange(lowerLimit, upperLimit);
            
            return result;
        }

        public static Image<Bgr, Byte> makeSmooth(Image<Bgr, Byte> input, Size size, int sigmaX, int sigmaY)
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

            // Converting the image from color to Gray
            CvInvoke.CvtColor(src, gray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            Mat edges = new Mat();

            // Detecting the edges
            CvInvoke.Canny(gray, edges, 60, 60 * 3);
            Image<Bgr, byte> res = new Image<Bgr, byte>(edges.Bitmap);
            return res;
        }
    }
}
