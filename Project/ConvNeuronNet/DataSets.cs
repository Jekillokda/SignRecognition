using System;
using System.IO;

namespace Project.ConvNeuronNet
{
    internal class DataSets
    {
        private const string Folder = @"..\Images\";
        private const string TrainLabelsPath = "TRlbls.txt";
        private const string trainingFolderPathI = "TrImageFolder";
        private const string TestLabelsPath = "TSTlbls.txt";
        private const string testingFolderPathI = "TstImageFolder";

        public DataSets(string pathL, string pathT)
        {
            
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
            Directory.CreateDirectory(Folder);

            var trainingLabelPath = Path.Combine(Folder, TrainLabelsPath);
            var trainingImageFilePath = Path.Combine(Folder, trainingFolderPathI);
            var testingLabelPath = Path.Combine(Folder, TestLabelsPath);
            var testingImageFilePath = Path.Combine(Folder, testingFolderPathI);
            Directory.CreateDirectory(trainingImageFilePath);
            Directory.CreateDirectory(testingImageFilePath);
            // Load data
            Console.WriteLine("Loading the datasets...");
            var train_images = ImageReader.Load(trainingLabelPath, trainingImageFilePath);
            var testing_images = ImageReader.Load(testingLabelPath, testingImageFilePath);
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