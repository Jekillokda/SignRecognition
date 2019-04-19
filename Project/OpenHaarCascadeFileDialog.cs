using System.Windows.Forms;

namespace Project
{
    class OpenHaarCascadeFileDialog
    {
        public static string openCascade()
        {
            string path = "";
            if (Properties.Settings.Default.last_path_to_cascade != "")
            {
                path = Properties.Settings.Default.last_path_to_cascade;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog.FileName;
                Properties.Settings.Default.last_path_to_cascade = path;
                Properties.Settings.Default.Save();
            }
            return path;
        }
    }
}