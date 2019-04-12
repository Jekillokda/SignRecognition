using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Cvb;

namespace Project
{
    class SignsHaarCascade
    {
        private CascadeClassifier cascadeClassifier;
        private 
        SignsHaarCascade(string path = @"cascade.xml") {
            cascadeClassifier = new CascadeClassifier(path);
    }
        /*FindObjects
        Image<Gray, Byte> grayImage = image.Convert<Gray, Byte>();
        var faces = _cascadeClassifier.DetectMultiScale(grayframe, 1.1, 10, Size.Empty); //the actual face detection happens here*/
    }
}
