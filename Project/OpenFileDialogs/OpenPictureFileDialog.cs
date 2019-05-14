using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;

namespace Project
{
    class OpenPictureFileDialog
    {
        static ImageFolder Imf = new ImageFolder();

        public static ImageFolder openFolder()
        {

            string[] arr = new string[0];
            string path = "";
            var dialog = new FolderBrowserDialog();
            dialog.SelectedPath = path;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.SelectedPath;
                Imf = new ImageFolder();
                Imf.load(path);
            }
            return Imf;
        }
    }
}
  
