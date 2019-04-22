using System.Windows.Forms;

namespace Project
{
    class OpenPictureFolderFileDialog
    {
        public static ImageFolder openFolder()
        {
            ImageFolder ImF = new ImageFolder("");
            string[] arr = new string[0];
            string path = "";
            if (Properties.Settings.Default.last_path_to_images != "")
            {
                path = Properties.Settings.Default.last_path_to_images;
            }
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;
                    ImF = new ImageFolder(path);
                    Properties.Settings.Default.last_path_to_videos = path;
                    Properties.Settings.Default.Save();
                }
            return ImF;
        }
    }
}