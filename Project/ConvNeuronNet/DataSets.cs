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

        public DataSet Test { get; set; }

        public bool Load()
        {
            Console.WriteLine("Loading the datasets...");
            Console.WriteLine("Loading train dataset");
            var train_images = ImageReader.Load(TrainPath);
            Console.WriteLine("Loaded the train dataset...");
            Console.WriteLine("Loading the test dataset...");
            var testing_images = ImageReader.Load(TestPath);
            Console.WriteLine("Loaded the test dataset...");
            if (train_images.Count == 0 || testing_images.Count == 0)
            {
                Console.WriteLine("Missing training/testing files.");
                return false;
            }

            Train = new DataSet(train_images);
            Test = new DataSet(testing_images);

            return true;
        }
    }
}