using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class OpenPictureFolderFileDialog
    {
        public static string[] openFolder()
        {
            string[] arr = new string[0];
            string path;
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;
                    arr = System.IO.Directory.GetFiles(path, "*.jpg,*.png");
                }
            return arr;
        }
    }
}
