using System;
using System.Collections.Generic;
using System.IO;
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

        public VideoFolder()
        {
            path = "";
            count = 0;
            videoArray = new string[0];
        }

        public int Load(string path)
        {
            this.path = path;
            if (Directory.Exists(path))
            {
                videoArray = System.IO.Directory.GetFiles(this.path, "*.mp4");
                count = videoArray.Length;
            }
            else
            {
                return -1;
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
        public string[] getAll()
        {
            return videoArray;
        }
        public string getVid(int n)
        {
            return videoArray[n];
        }
    }
}
