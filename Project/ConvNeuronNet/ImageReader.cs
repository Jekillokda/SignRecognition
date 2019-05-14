using Emgu.CV;
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
            var label = LoadLabels(Path, maxItem);
            var images = LoadImages(Path, maxItem);

            if (label.Count == 0 || images.Count == 0)
            {
                return new List<ImageEntry>();
            }

            return label.Select((t, i) => new ImageEntry { Label = t, Image = images[i] }).ToList();
        }

        private static List<byte[]> LoadImages(string path, int maxItem = -1)
        {
            var result = new List<byte[]>();
            ImageFolder f = new ImageFolder();
            f.load(path);

            foreach (string imgpath in f.getAllImgs())
            {
                Mat tmp = new Mat(imgpath);
                tmp = ImgOps.InterpolationResize(tmp, 32, 32);
                tmp = ImgOps.RGBtoGrey(tmp).Mat;
                byte[] res = new byte[tmp.Height * tmp.Width];
                for (int i = 0; i < tmp.Height; i++)
                {
                    for (int j = 0; j < tmp.Width; j++)
                    {
                        res[i * tmp.Width + j] = tmp.Bitmap.GetPixel(j,i).R;
                    }
                }
                result.Add(res);
            }

            return result;
        }

        private static List<int> LoadLabels(string path, int maxItem = -1)
        {
            var result = new List<int>();
            var name = "labels.txt";
            var filePath = Path.Combine(path, name);
            if (File.Exists(filePath))
            {
                string labels = File.ReadAllText(filePath, Encoding.UTF8)+ " ";
                string tmp = "";
                int c = 0;
                int i = 0;
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
            }

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
