using System.Windows.Forms;

namespace Project
{
    class OpenVideoFolderFileDialog
    {
        public static string[] openFolder()
        {
            string[] arr = new string[0];
            string path; 
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;
                    arr = System.IO.Directory.GetFiles(path, "*.mp4");        
                }
            return arr;
        }
    }
    
}
