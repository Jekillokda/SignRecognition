using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ImageFolder
    {
        public string path { get; set; }
        public int count { get; set; }
        string[] imageArray;

        public ImageFolder(string path)
        {
            this.path = path;
            imageArray = System.IO.Directory.GetFiles(path, "*.png|*.jpg");
            count = imageArray.Length;
        }
    }
}
