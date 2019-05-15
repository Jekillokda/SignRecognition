using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.OpenFileDialogs
{
    class OpenTextFileDialog
    {
        public static string openFile()
        {
            string path = "";
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "text files (*.txt)|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.FileName;
            }

            dlg.Dispose();
            return path;
        }
    }
}
