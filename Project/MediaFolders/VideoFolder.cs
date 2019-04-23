using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class VideoFolder
    {
        private string path { get; set; }
        private int count { get; set; }
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
    }
}
