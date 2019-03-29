using Emgu.CV;
using Emgu.CV.Structure;
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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return img;
        }
    }
}
