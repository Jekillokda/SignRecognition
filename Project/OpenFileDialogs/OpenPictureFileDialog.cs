using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;

namespace Project
{
    class OpenPictureFileDialog
    { 
        public static string openFile()
        {
            string path = "";
            OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "Open Image",
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
        };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.FileName;
            }

            dlg.Dispose();
            return path;
        }
    }
}
  
