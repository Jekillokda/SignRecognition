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
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;
                    ImF = new ImageFolder();
                    ImF.load(path);
                }
            return ImF;
        }
    }
}