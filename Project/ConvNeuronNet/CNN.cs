using ConvNetSharp.Core;
using ConvNetSharp.Core.Layers.Double;
using ConvNetSharp.Core.Serialization;
using ConvNetSharp.Core.Training;
using ConvNetSharp.Volume;
using ConvNetSharp.Volume.Double;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ConvNeuronNet
{
    class CNN
    {
        Net<double> net;
        int stepCount;
        string loadedJson;
        string JsonToSave;
        int Aim;
        double Acc = 0;
        int classes;
        bool isNetLearned;
        private SgdTrainer<double> trainer;
        string path = @"D:\road-video\CNN.txt";
        private ConvLayer convLayer;

        private readonly CircularBuffer<double> testAccWindow = new CircularBuffer<double>(100);
        private readonly CircularBuffer<double> trainAccWindow = new CircularBuffer<double>(100);

        public CNN()
        {
            net = new Net<double>();
            Aim = 90;
            isNetLearned = false;
        }
        public int createCNN(int inpx = 32, int inpy = 32, int inpd = 1, int classesCount = 10)
        {
            //net.AddLayer(new InputLayer(inpx, inpy, inpd));
            //net.AddLayer(new ConvLayer(5, 5, 14) {Stride = 1, Pad = 2});
            //net.AddLayer(new ReluLayer());
            //net.AddLayer(new PoolLayer(2, 2) {Stride = 2});
            //net.AddLayer(new ConvLayer(5, 5, 28) {Stride = 1, Pad = 2});
            //net.AddLayer(new ReluLayer());
            //net.AddLayer(new PoolLayer(2, 2) {Stride = 2});
            //net.AddLayer(new FullyConnLayer(150));
            ////net.AddLayer(new DropoutLayer(0.5));
            //net.AddLayer(new FullyConnLayer(100));
            ////net.AddLayer(new DropoutLayer(0.5));
            //net.AddLayer(new FullyConnLayer(10));
            //net.AddLayer(new SoftmaxLayer(10));
            this.net.AddLayer(new InputLayer(32, 32, 1));
            this.convLayer = new ConvLayer(5, 5, 8) { Stride = 1, Pad = 2 };
            this.net.AddLayer(this.convLayer);
            this.net.AddLayer(new ReluLayer());
            this.net.AddLayer(new PoolLayer(2, 2) { Stride = 2 });
            this.net.AddLayer(new ConvLayer(5, 5, 16) { Stride = 1, Pad = 2 });
            this.net.AddLayer(new ReluLayer());
            this.net.AddLayer(new PoolLayer(3, 3) { Stride = 3 });
            this.net.AddLayer(new FullyConnLayer(10));
            this.net.AddLayer(new SoftmaxLayer(10));
            return net.Layers.Count;
        }

        private void Test(Volume<double> x, int[] labels, CircularBuffer<double> accuracy, bool forward = true)
        {
            if (forward)
            {
                net.Forward(x);
            }

            var prediction = net.GetPrediction();

            for (var i = 0; i < labels.Length; i++)
            {
                accuracy.Add(labels[i] == prediction[i] ? 1.0 : 0.0);
            }
        }

        public double teachCNN(string pathL, string pathT)
        {
            if (net.Layers.Count == 0)
            {
                this.createCNN();
            }
            var datasets = new DataSets(pathL, pathT);
            if (!datasets.Load(100))
            {
                return -2;
            }
            this.trainer = new SgdTrainer<double>(this.net)
            {
                LearningRate = 0.02,
                BatchSize = 50,
                Momentum = 0.9
            };
        
            if (net.Layers.Count > 0)
            {
                do
                {
                    var trainSample = datasets.Train.NextBatch(trainer.BatchSize, classes);
                    Train(trainSample.Item1, trainSample.Item2, trainSample.Item3);

                    var testSample = datasets.Test.NextBatch(trainer.BatchSize, classes);
                    Test(testSample.Item1, testSample.Item3, testAccWindow);

                    Console.WriteLine("Loss: {0} Train accuracy: {1}% Test accuracy: {2}%", trainer.Loss,
                        Math.Round(trainAccWindow.Items.Average() * 100.0, 2),
                        Math.Round(testAccWindow.Items.Average() * 100.0, 2));

                    Console.WriteLine("Example seen: {0} Fwd: {1}ms Bckw: {2}ms", stepCount,
                        Math.Round(trainer.ForwardTimeMs, 2),
                        Math.Round(trainer.BackwardTimeMs, 2));
                    Acc = Math.Round(testAccWindow.Items.Average() * 100.0, 2);
                } while (Acc < Aim);

                Console.WriteLine($"{stepCount}");
                isNetLearned = true;
                return trainer.Loss;
            }
            
            else return -1;
        }

        public string saveCNN()
        {
            if (net.Layers.Count > 0)
            {
                JsonToSave = net.ToJson();
                File.WriteAllText(path, JsonToSave);
                return JsonToSave;
            }
            else return "";
        }

        public int loadCNN()
        {
            if (path!= "")
            {
                loadedJson = File.ReadAllText(path);
                var deserialized = SerializationExtensions.FromJson<double>(loadedJson);
                this.net = deserialized;
                isNetLearned = true;
                return net.Layers.Count;
            }
            else return -1;
        }

        public string recognize(byte[] image)
        {

                if (image.Length != 32 * 32)
                {
                    return "ERROR";
                }
                if (net.Layers.Count == 0)
                {
                    this.createCNN();
                    loadCNN();
                }
                var dataShape = new Shape(32, 32, 1, 1);
                var data = new double[dataShape.TotalLength];
                var dataVolume = BuilderInstance.Volume.From(data, dataShape);

                var j = 0;
                for (var y = 0; y < 32; y++)
                {
                    for (var x = 0; x < 32; x++)
                    {
                        dataVolume.Set(x, y, 0, 0, image[j++]);
                    }
                }
                net.Forward(dataVolume);
                var prediction = net.GetPrediction();
                return getClassNameFromNumver(prediction[0]);
        }

        private void Train(Volume<double> x, Volume<double> y, int[] labels)
        {
            this.trainer.Train(x, y);

            Test(x, labels, this.trainAccWindow, false);

            stepCount += labels.Length;
        }

        public int getLayersCount()
        {
            return net.Layers.Count;
        }

        public int getClassesCount()
        {
            return this.classes;
        }

        public bool isLearned()
        {
            return this.isNetLearned;
        }

        public string getClassNameFromNumver(int n)
        {
            switch (n)
            {
                case 1:
                    return "60 km/h";
                case 2:
                    return "Main road";
                case 3:
                    return "Secondary road";
                case 4:
                    return "Stop sign";
                case 5:
                    return "Road up";
                case 6:
                    return "Kirpich";
                case 7:
                    return "Warning";
                case 8:
                    return "Sleeping policeman";
                case 9:
                    return "Road Works";
                case 10:
                    return "Only forward";
                default:
                    break;

            }
            return "";  
        }
    }
}