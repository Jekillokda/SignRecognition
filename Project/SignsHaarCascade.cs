using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Cvb;
using System.Drawing;

namespace Project
{
    class SignsHaarCascade 
    {
        public CascadeClassifier cascadeClassifier;
        public SignsHaarCascade(string path = @"cascade.xml")
        {
            cascadeClassifier = new CascadeClassifier(path);
        }
        public Rectangle[] detect(Image<Gray,Byte> img)
        {
            Rectangle[] arr = cascadeClassifier.DetectMultiScale(img);
            return arr;
        }
        public Image<Gray, Byte> drawRects(Image<Gray, Byte> img,Rectangle[] rexct)
        {

            return img;
        }
    }
}
