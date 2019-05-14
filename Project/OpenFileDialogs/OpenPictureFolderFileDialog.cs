using System.Windows.Forms;

namespace Project
{
    class OpenPictureFolderFileDialog
    {
        static ImageFolder ImF = new ImageFolder();
        public static ImageFolder openFolder()
        {
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
                    ImF = new ImageFolder();
                    ImF.load(path);
                    Properties.Settings.Default.last_path_to_videos = path;
                    Properties.Settings.Default.Save();
                }
            return ImF;
        }
    }
}