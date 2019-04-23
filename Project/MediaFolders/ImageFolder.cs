using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ImageFolder
    {
        private string path { get; set; }
        private int count { get; set; }
        string[] imageArray;

        public ImageFolder(string path)
        {
            this.path = path;
            imageArray = System.IO.Directory.GetFiles(path, "*.png|*.jpg");
            count = imageArray.Length;
        }
        public int getCount()
        {
            return this.count;
        }
    }
}
