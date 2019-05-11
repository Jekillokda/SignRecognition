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
        public static List<ImageEntry> Load(string labelPath, string imagesPath, int maxItem = -1)
        {
            var label = LoadLabels(labelPath, maxItem);
            var images = LoadImages(imagesPath, maxItem);

            if (label.Count == 0 || images.Count == 0)
            {
                return new List<ImageEntry>();
            }

            return label.Select((t, i) => new ImageEntry { Label = t, Image = images[i] }).ToList();
        }

        private static List<byte[]> LoadImages(string path, int maxItem = -1)
        {
            var result = new List<byte[]>();
            ImageFolder f = new ImageFolder(path);

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

        private static List<int> LoadLabels(string filename, int maxItem = -1)
        {
            var result = new List<int>();

            if (File.Exists(filename))
            {
                string labels = File.ReadAllText(filename, Encoding.UTF8);
                string tmp = "";
                int c = 0;
                for(int i = 0; i < labels.Length; i++)
                {
                    if ((labels[i] != ' ')&&(i<labels.Length-1))
                        tmp += labels[i];
                    else
                    {
                        result.Add(Int32.Parse(tmp));
                        tmp = "";
                        c++;
                    }


                }
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
