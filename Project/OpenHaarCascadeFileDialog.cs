
using System.Windows.Forms;

namespace Project
{
    class OpenHaarCascadeFileDialog
    {
        public static string openCascade()
        {
            string path = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }
            return path;
        }
    }
}
