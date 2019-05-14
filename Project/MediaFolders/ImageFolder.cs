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
        }
        public int load(string path)
        {
            this.path = path;
            if (Directory.Exists(path))
            {
                imageArray = System.IO.Directory.GetFiles(path, "*.jpg");
                count = imageArray.Length;
            }
            else
            {
                imageArray = new string[0];
                count = 0;
            }
                
            return count;
        }

        public int getCount()
        {
            return count;
        }
        public string getPath()
        {
            return path;
        }
        public void setPath(string path)
        {
            this.path = path;
        }
        public string[] getAllImgs()
        {
            return imageArray;
        }
        public string getImg(int n)
        {
            return imageArray[n];
        }
    }
}