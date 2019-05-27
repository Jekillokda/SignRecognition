using System.Windows.Forms;

namespace Project
{
    class OpenHaarCascadeFileDialog
    {
        static SignsHaarCascade cascade;
        public static SignsHaarCascade openCascade(string defPath = "")
        {
            string path = "";
            if (defPath == "")
            {
                if (Properties.Settings.Default.last_path_to_cascades != "")
                {
                    path = Properties.Settings.Default.last_path_to_cascades;
                }
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "XML Files|*.xml"
                };
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    cascade = new SignsHaarCascade(path);
                }
            }
            else
            {
                cascade = new SignsHaarCascade(defPath);
            }
            return cascade;
        }
    }
}