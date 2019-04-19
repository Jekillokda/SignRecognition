using System;
using System.Collections.Generic;
using Emgu.CV;

using System.Drawing;

namespace Project
{
    class SignsHaarCascade 
    {
        public CascadeClassifier cascadeClassifier;
        string path;
        public SignsHaarCascade(string path)
        {
            this.path = path;
            if (path != "")
            {
                cascadeClassifier = new CascadeClassifier(this.path);
            }
        }
        public List<Mat> getListOfROI(Mat img, Rectangle[] rects)
        {
            List<Mat> list = new List<Mat>();
            Mat tmp;
            foreach (Rectangle rect in rects)
            {
                tmp = new Mat(img, rect);
                list.Add(tmp);
            }
            return list;
        }
        public List<Mat> detectAll(Mat img)
        {
            Rectangle[] arr = cascadeClassifier.DetectMultiScale(img);
            List<Mat> detectList = getListOfROI(img, arr);
            return detectList;
        }
    }
}
