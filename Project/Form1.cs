using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
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

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            openFileDialog2.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            Mat modelImage = new Mat();
            Mat observedImage = new Mat();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                modelImage = CvInvoke.Imread(openFileDialog1.FileName);
            }
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                observedImage = CvInvoke.Imread(openFileDialog2.FileName);
            }
                
            //Shape Detection
           /* imgbox1.Image = modelImage;
             try {
                 Image<Bgr, byte> img = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
                 imgbox2.Image = ShapeDetection.detectShape(img);
             }
             catch(Exception ex) {
                 MessageBox.Show(ex.Message);
             }*/
           
            // RGB to HSV
            /*Emgu.CV.Image<Bgr, Byte> imgBgr = new Image<Bgr, Byte>(openFileDialog1.FileName);

            CvInvoke.Imshow("Img BGR", imgBgr);

            Bgr color = imgBgr[0,0];

            Emgu.CV.Image<Hsv, Byte> imgHsv = new Image<Hsv, Byte>(openFileDialog1.FileName);

            CvInvoke.Resize(imgHsv, imgHsv, new Size(1600,800));

            CvInvoke.Imshow("Img HSV", imgHsv);

            Hsv colorHsv = imgHsv[0,0];*/
            
           // Shape Comparation
           long matchTime;
           Mat result = ShapeComparation.Draw(modelImage, observedImage, out matchTime);

           imgbox2.Image = observedImage;
           imgbox3.Image = result;
           l_matchTime.Text = matchTime.ToString();

        }
    }
}