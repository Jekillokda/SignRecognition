using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MediaFolders
{
    class XmlFolder
    {
        private string path;
        private int count;
        public string[] xmlArray;

        public XmlFolder()
        {
            path = "";
            count = 0;
            xmlArray = new string[1];
            xmlArray[0] = "";
        }

        public int Load(string path)
        {
            this.path = path;
            if (Directory.Exists(path))
            {
                xmlArray = System.IO.Directory.GetFiles(path, "*.xml");
                count = xmlArray.Length;
            }
            else
            {
                xmlArray = new string[0];
                count = 0;
            }

            return count;
        }
        public int GetCount()
        {
            return count;
        }
        public string GetPath()
        {
            return path;
        }
        public void SetPath(string path)
        {
            this.path = path;
            Load(path);
        }
        public string[] GetAll()
        {
            return xmlArray;
        }
        public string GetXml(int n)
        {
            return xmlArray[n];
        }
        public string GetFolderPath()
        {
            return path;
        }
    }
}
