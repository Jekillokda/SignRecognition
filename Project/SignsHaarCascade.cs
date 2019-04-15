﻿using System;
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
        public SignsHaarCascade(string path)
        {
            cascadeClassifier = new CascadeClassifier(path);
        }
        public Rectangle[] detectHaar(Mat img)
        {
            Rectangle[] arr = cascadeClassifier.DetectMultiScale(img,1.1,3,new Size(50,50), new Size(100,100));
            return arr;
        }
        public List<Mat> getListOfROI(Mat img, Rectangle[] rects)
        {
            List<Mat> list = new List<Mat>();
            Mat tmp;
            foreach (Rectangle rect in rects) {
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
