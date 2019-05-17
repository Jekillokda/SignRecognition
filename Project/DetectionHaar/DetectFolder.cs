using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DetectionHaar
{
    static class DetectFolder
    {

        public static bool DetectAll(string folderPath, string[] cascadesPath, string savePath)
        {
            List<SignsHaarCascade> cascadesList = new List<SignsHaarCascade>();
            List<ImageFolder> foldersList = new List<ImageFolder>();
            foreach(string casPath in cascadesPath)
            {
                cascadesList.Add(new SignsHaarCascade(casPath));
            }
            ImageFolder f = new ImageFolder();
            f.Load(folderPath);
                int c = 0;
                foreach (string image_path in f.GetAllImgs())
                {
                    Mat img = new Image<Bgr, byte>(image_path).Mat;
                    foreach(SignsHaarCascade cascade in cascadesList)
                    {
                        Console.WriteLine(f.GetPath());
                        Console.WriteLine(c++);
                        List<Mat> list = cascade.detectAll(img, 1.1, 4);
                        var n = new DirectoryInfo(f.GetPath()).Name;
                        var newFolderPath = Path.Combine(savePath, n.ToString());
                        var imageName = Path.GetFileNameWithoutExtension(image_path);
                        
                        for (int i = 0; i < list.Count; i++)
                            list[i].Save(newFolderPath +"_" + imageName+ "_" + i + ".jpg");
                    }                  
                }

            return false;
        }
    }
}
