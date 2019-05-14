using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ConvNeuronNet
{
    public static class ImageReader
    {
        public static List<ImageEntry> Load(string Path, int maxItem = -1)
        {
           
            var images = LoadImages(Path, out ImageFolder fold, maxItem);
            var label = LoadLabels(Path, fold, maxItem);

            if (label.Count == 0 || images.Count == 0)
            {
                return new List<ImageEntry>();
            }

            return label.Select((t, i) => new ImageEntry { Label = t, Image = images[i] }).ToList();
        }

        private static List<byte[]> LoadImages(string path,out ImageFolder fold, int maxItem = -1)
        {
            var result = new List<byte[]>();
            var f = new ImageFolder();
            f.load(path);
            int counter = 0;
            foreach (string imgpath in f.getAllImgs())
            {
                Console.WriteLine(counter++);
                result.Add(new Image<Gray, byte>(imgpath).Bytes);
            }
            fold = f;
            return result;
        }

        private static List<int> LoadLabels(string path, ImageFolder f, int maxItem = -1 )
        {
            var result = new List<int>();
            var name = "labels.txt";
            var filePath = Path.Combine(path, name);
            string labels = "";

            if(File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            if (!File.Exists(filePath))
            {
                foreach (string imgpath in f.getAllImgs())
                {
                    string n = Path.GetFileName(imgpath);

                    n = n.Substring(n.IndexOf('_') + 1, n.IndexOf('.') - n.IndexOf('_') - 1);

                    labels += " " + n;
                }
                File.WriteAllText(filePath, labels);
            }
            labels = File.ReadAllText(filePath, Encoding.UTF8) + " ";
            int c = 0;
            int i = 0;
            string tmp = "";
            do
            {
                if ((labels[i] != ' '))
                    tmp += labels[i];
                else
                {
                    if (tmp.Length > 0)
                    {
                        result.Add(Int32.Parse(tmp));
                        tmp = "";
                        c++;
                    }
                }
                i++;
            } while (i < labels.Length);
            return result;
        }

        private static int ReverseBytes(int v)
        {
            var intAsBytes = BitConverter.GetBytes(v);
            Array.Reverse(intAsBytes);
            return BitConverter.ToInt32(intAsBytes, 0);
        }
    }
}
