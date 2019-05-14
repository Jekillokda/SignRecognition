using System;
using System.IO;

namespace Project.ConvNeuronNet
{
    internal class DataSets
    {
        string TrainPath;
        string TestPath;
        public DataSets(string pathL, string pathT)
        {
            TrainPath = pathL;
            TestPath = pathT;
        }

        public DataSet Train { get; set; }

        public DataSet Validation { get; set; }

        public DataSet Test { get; set; }

        private void DownloadFile(string urlFile, string destFilepath)
        {
            if (!File.Exists(destFilepath))
            {
                try
                {
                    using (var client = new System.Net.WebClient())
                    {
                        client.DownloadFile(urlFile, destFilepath);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed downloading " + urlFile);
                    Console.WriteLine(e.Message);
                }
            }
        }

        public bool Load(int validationSize = 10)
        {
            // Load data
            Console.WriteLine("Loading the datasets...");
            var train_images = ImageReader.Load(TrainPath);
            var testing_images = ImageReader.Load(TestPath);
            var valiation_images = train_images.GetRange(train_images.Count - validationSize, validationSize);

            train_images = train_images.GetRange(0, train_images.Count - validationSize);

            if (train_images.Count == 0 || valiation_images.Count == 0 || testing_images.Count == 0)
            {
                Console.WriteLine("Missing training/testing files.");
                Console.ReadKey();
                return false;
            }

            Train = new DataSet(train_images);
            Validation = new DataSet(valiation_images);
            Test = new DataSet(testing_images);

            return true;
        }
    }
}