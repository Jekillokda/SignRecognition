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
            if ((path != "")&&(path != null))
            {
                imageArray = System.IO.Directory.GetFiles(path, "*.jpg");
                count = imageArray.Length;
            }            
        }

        public int getCount()
        {
            return count;
        }
        public string getPath()
        {
            return path;
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