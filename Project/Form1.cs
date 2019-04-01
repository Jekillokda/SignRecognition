using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgOrigin1;
        Image<Bgr, byte> imgOrigin2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_img1_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgOrigin1 = CvInvoke.Imread(openFileDialog1.FileName).ToImage<Bgr, Byte>();
                imgbox1.Image = imgOrigin1;
            }
        }

        private void btn_img2_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgOrigin2 = CvInvoke.Imread(openFileDialog2.FileName).ToImage<Bgr, Byte>();
                imgbox2.Image = imgOrigin2;
            }
        }

        private void btn_img1_toOrigin_Click(object sender, EventArgs e)
        {
            imgbox1.Image = imgOrigin1;
        }

        private void btn_img2_toOrigin_Click(object sender, EventArgs e)
        {
            imgbox2.Image = imgOrigin2;
        }

        private void btn_img1_tohsv_Click(object sender, EventArgs e)
        {
            imgbox1.Image = ImgOps.RGBtoHSV(new Image<Bgr, byte>(imgbox1.Image.Bitmap).Mat);
        }

        private void btn_img2_tohsv_Click(object sender, EventArgs e)
        {
            imgbox2.Image = ImgOps.RGBtoHSV(new Image<Bgr, byte>(imgbox2.Image.Bitmap).Mat);
        }

        private void btn_img1_togrey_Click(object sender, EventArgs e)
        {
            imgbox1.Image = ImgOps.RGBtoGrey(new Image<Bgr, byte>(imgbox1.Image.Bitmap).Mat);
        }

        private void btn_img2_togrey_Click(object sender, EventArgs e)
        {
            imgbox2.Image = ImgOps.RGBtoGrey(new Image<Bgr, byte>(imgbox2.Image.Bitmap).Mat);
        }

        private void btn_compare_Click(object sender, EventArgs e)
        {
            bool matchfound = false;
            long matchTime;
            Mat result = new Mat();
            if ((imgbox1.Image != null) && (imgbox1.Image != null))
            {
                result = ShapeComparation.Draw((new Image<Bgr, byte>(imgbox1.Image.Bitmap).Mat), (new Image<Bgr, byte>(imgbox2.Image.Bitmap).Mat), out matchTime, ref matchfound);
                l_matchtime.Text = matchTime.ToString() + " ms";
            }
            else
            {
                MessageBox.Show("Load images and try again", "Error");
            }
            if (matchfound == true)
            {
                l_matchfound.Text = "Found";
            }
            imgbox3.Image = result;
        }

        private void btn_detect_Click(object sender, EventArgs e)
        {
            try
            {
                Image<Bgr, byte> img = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
                imgbox3.Image = ShapeDetection.detectShape(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }  

        private void btn_detectLines_Click(object sender, EventArgs e)
        {
            try
            {
                Image<Bgr, byte> img = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
                imgbox3.Image = ShapeDetection.detectShape2(img, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_detectTriangles_Click(object sender, EventArgs e)
        {
            try
            {
                Image<Bgr, byte> img = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
                imgbox3.Image = ShapeDetection.detectShape2(img, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_detectRectangles_Click(object sender, EventArgs e)
        {
            try
            {
                Image<Bgr, byte> img = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
                imgbox3.Image = ShapeDetection.detectShape2(img, 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_detectCircles_Click(object sender, EventArgs e)
        {
            try
            {
                Image<Bgr, byte> img = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
                imgbox3.Image = ShapeDetection.detectShape2(img, 4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_img1_denoise_Click(object sender, EventArgs e)
        {
            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(imgbox1.Image, pyrDown);
            Image<Bgr,byte> res = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
            CvInvoke.PyrUp(pyrDown, res);
            imgbox1.Image = res;
        }

        private void btn_img2_denoise_Click(object sender, EventArgs e)
        {
            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(imgbox2.Image, pyrDown);
            Image<Bgr, byte> res = new Image<Bgr, byte>(imgbox2.Image.Bitmap);
            CvInvoke.PyrUp(pyrDown, res);
            imgbox2.Image = res;
        }

        private void btn_img1_tobinary_Click(object sender, EventArgs e)
        {
            try
            {
                Mat tmp = (new Image<Bgr, byte>(imgbox1.Image.Bitmap).Mat);
                tmp = ImgOps.RGBtoGrey(new Image<Bgr, byte>(tmp.Bitmap).Mat);
                CvInvoke.Threshold(tmp, tmp, 200, 255, 0);
                imgbox1.Image = tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_img2_tobinary_Click(object sender, EventArgs e)
        {
            try
            {
                Mat tmp = (new Image<Bgr, byte>(imgbox2.Image.Bitmap).Mat);
                tmp = ImgOps.RGBtoGrey(new Image<Bgr, byte>(tmp.Bitmap).Mat);
                CvInvoke.Threshold(tmp, tmp, 200, 255, 0);
                imgbox2.Image = tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}