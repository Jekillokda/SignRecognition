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
            
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            openFileDialog2.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            Mat image1 = new Mat();
            Mat image2 = new Mat();

            //open 1st img
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image1 = CvInvoke.Imread(openFileDialog1.FileName);
            }
 
            //open 2nd image
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image2 = CvInvoke.Imread(openFileDialog2.FileName);
            }

            //Shape Detection
            /* imgbox1.Image = image1;
              try {
                  Image<Bgr, byte> img = new Image<Bgr, byte>(imgbox1.Image.Bitmap);
                  imgbox2.Image = ShapeDetection.detectShape(img);
              }
              catch(Exception ex) {
                  MessageBox.Show(ex.Message);
              }*/

            // Shape Comparation
            long matchTime;
            Mat imgHSV1 = ImgOps.RGBtoHSV(image1);
            Mat imgHSV2 = ImgOps.RGBtoHSV(image2);
            Mat imgGrey1 = ImgOps.RGBtoGrey(image1);
            Mat imgGrey2 = ImgOps.RGBtoGrey(image2);
            bool matchfound = false; 
            Mat result = ShapeComparation.Draw(imgGrey1, imgGrey2, out matchTime, ref matchfound);

            //imgbox1.Image = image2;
            //imgbox2.Image = image1;
            imgbox1.Image = imgGrey1;
            imgbox2.Image = imgGrey2;
            imgbox3.Image = result;
            if (matchfound == true)
            {
                l_matchfound.Text = "Found";
            }
            l_matchtime.Text = matchTime.ToString() +" ms";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgbox1.Image = CvInvoke.Imread(openFileDialog1.FileName);
            }
        }
    }
}