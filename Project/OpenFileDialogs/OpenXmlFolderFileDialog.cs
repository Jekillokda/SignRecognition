using Project.MediaFolders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.OpenFileDialogs
{
    class OpenXmlFolderFileDialog
    {
        static XmlFolder xmlFolder = new XmlFolder();
        public static XmlFolder openFolder()
        {
            string[] arr = new string[0];
            string path = "";
            if (Properties.Settings.Default.last_path_to_cascades != "")
            {
                path = Properties.Settings.Default.last_path_to_cascades;
            }
            var dialog = new FolderBrowserDialog();
            dialog.SelectedPath = path;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.SelectedPath;
                xmlFolder = new XmlFolder();
                xmlFolder.Load(path);
            }
            return xmlFolder;
        }
    }
}
