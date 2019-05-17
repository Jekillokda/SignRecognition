using System;
using System.Collections.Generic;
using Emgu.CV;

using System.Drawing;

namespace Project
{
    class SignsHaarCascade 
    {
        public CascadeClassifier cascadeClassifier;
        private string path;
        public SignsHaarCascade(string path)
        {
            this.path = path;
            if (this.path != "")
            {
                cascadeClassifier = new CascadeClassifier(this.path);
            }
        }
        public List<Mat> detectAll(Mat img, double sFactor = 1.1, int minNeigh = 4)
        {
            List<Mat> list = new List<Mat>();
            foreach (Rectangle rect in cascadeClassifier.DetectMultiScale(img, sFactor, minNeigh))
            {
                list.Add(new Mat(img, rect));
            }
            return list;
        }
        public string getPath()
        {
            return this.path;
        }
    }
}
