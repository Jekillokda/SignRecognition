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

        public ImageFolder(string path)
        {

            this.path = path;
            if (path != "")
            {
                imageArray = System.IO.Directory.GetFiles(path, "*.jpg");
                count = imageArray.Length;
            }            
        }

        public int getCount()
        {
            return this.count;
        }
        public string getPath()
        {
            return this.path;
        }
        public string[] getAllImgs()
        {
            return this.imageArray;
        }
        public string getImg(int n)
        {
            return this.imageArray[n];
        }
    }
}