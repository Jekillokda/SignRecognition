using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ImageFolder
    {
        private string path;
        private int count;
        private string[] imageArray;

        public ImageFolder()
        {
            path = "";
            count = 0;
            imageArray = new string[0];
        }

        public int Load(string path)
        {
            this.path = path;
            string[] tmp;
            if (Directory.Exists(path))
            {
                imageArray = System.IO.Directory.GetFiles(path, "*.jpg");
                tmp = System.IO.Directory.GetFiles(path, "*.png");
                imageArray.Concat( tmp);
                count = imageArray.Length;
            }
            else
            {
                imageArray = new string[0];
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
            return imageArray;
        }
        public string GetImg(int n)
        {
            return imageArray[n];
        }
        public bool Sort()
        {
            string[] arr = new string[GetCount()];
            for (int i = 1; i < GetCount(); i++)
            {
                string tmp = Path.GetFileName(GetImg(i-1));
                tmp = tmp.Substring(tmp.LastIndexOf("_")+1, tmp.LastIndexOf(".") - tmp.LastIndexOf("_")-1);
                int n = 1;
                int.TryParse(tmp, out n);
                Console.WriteLine(i.ToString() + " " + n.ToString());
                arr[n - 1] = GetImg(i);
            }
            imageArray = arr;
            return false;
        }
    }
}