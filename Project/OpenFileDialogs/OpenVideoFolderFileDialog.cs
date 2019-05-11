using System.Windows.Forms;

namespace Project
{
    class OpenVideoFolderFileDialog
    {
        static VideoFolder Vf = new VideoFolder("");
        public static VideoFolder openFolder()
        {
            string[] arr = new string[0];
            string path = "";
            if (Properties.Settings.Default.last_path_to_videos!= "")
            {
                path = Properties.Settings.Default.last_path_to_videos;
            }
            var dialog = new FolderBrowserDialog();
            dialog.SelectedPath = path;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;
                    Vf = new VideoFolder(path);
                    Properties.Settings.Default.last_path_to_videos = path;
                    Properties.Settings.Default.Save(); 
            }
            return Vf;
        }
    }
}
