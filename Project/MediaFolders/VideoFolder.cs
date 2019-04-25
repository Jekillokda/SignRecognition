using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class VideoFolder
    {
        private string path;
        private int count;
        public string[] videoArray;
        public VideoFolder(string path)
        {
            this.path = path;
            if (path != "")
            {
                videoArray = System.IO.Directory.GetFiles(this.path, "*.mp4");
                count = videoArray.Length;
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
    }
}
