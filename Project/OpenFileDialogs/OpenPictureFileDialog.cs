using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;

namespace Project
{
    class OpenPictureFileDialog
    {
        OpenPictureFileDialog()
        {
        }

        public static Image<Bgr, byte> OpenPicture()
        {
            Image<Bgr, byte> img = new Image<Bgr, byte>(1,1);
            try {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    img = CvInvoke.Imread(openFileDialog.FileName).ToImage<Bgr, Byte>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return img;
        }
    }
}
  
