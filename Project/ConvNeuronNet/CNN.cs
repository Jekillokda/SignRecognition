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
        double Acc;
        int classes;
        bool isNetLearned;
        private SgdTrainer<double> trainer;
        string path;
        private ConvLayer convLayer;

        private readonly CircularBuffer<double> testAccWindow = new CircularBuffer<double>(100);
        private readonly CircularBuffer<double> trainAccWindow = new CircularBuffer<double>(100);

        public CNN(string path)
        {
            net = new Net<double>();
            Aim = 0;
            Acc = 0;
            isNetLearned = false;
            path = "";
        }
        public int CreateCNN(int inpx = 32, int inpy = 32, int inpd = 1, int classesCount = 11)
        {
            if (GetLayersCount() == 0)
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
                this.net.AddLayer(new InputLayer(inpx,inpy, 1));
                this.convLayer = new ConvLayer(3, 3, 4) { Stride = 1, Pad = 2 };
                this.net.AddLayer(this.convLayer);
                this.net.AddLayer(new ReluLayer());
                this.net.AddLayer(new PoolLayer(2, 2) { Stride = 2 });
                this.net.AddLayer(new ConvLayer(5, 5, 8) { Stride = 1, Pad = 2 });
                this.net.AddLayer(new ReluLayer());
                this.net.AddLayer(new PoolLayer(3, 3) { Stride = 3 });
                this.net.AddLayer(new FullyConnLayer(2*classesCount));
                this.net.AddLayer(new FullyConnLayer(classesCount));
                this.net.AddLayer(new SoftmaxLayer(classesCount));
                classes = classesCount;
            }
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

        public double TeachCNN(string pathL, string pathT, int acc, double learnRate,int size, double mom)
        {
            if (net.Layers.Count == 0)
            {
                this.CreateCNN();
            }
            var datasets = new DataSets(pathL, pathT);
            if (!datasets.Load(2*size))
            {
                return -2;
            }
            Aim = acc;
            this.trainer = new SgdTrainer<double>(this.net)
            {
                LearningRate = learnRate,
                BatchSize = size,
                Momentum = mom
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
                return Acc;
            }
            
            else return -1;
        }

        public string SaveCNN(string tmppath)
        {
            if (net.Layers.Count > 0)
            {
               
                JsonToSave = net.ToJson();
                var name = "CNN_" + GetAccuracy().ToString() + ".txt";
                var newPath = Path.Combine(Path.GetDirectoryName(tmppath), name);
                if (File.Exists(newPath))
                {
                    File.Delete(newPath);
                }
               // File.Create(newPath);
                File.WriteAllText(newPath, JsonToSave);
                return newPath;
            }
            else return "";
        }

        public int LoadCNN(string path)
        {
            if (path!= "")
            {
                loadedJson = File.ReadAllText(path);
                var deserialized = SerializationExtensions.FromJson<double>(loadedJson);
                this.net = deserialized;
                isNetLearned = true;
                this.path = path;
                classes = deserialized.Layers[GetLayersCount() - 1].OutputDepth;
                return net.Layers.Count;
            }
            else return -1;
        }

        public string Recognize(byte[] image)
        {
            if (image.Length != net.Layers[0].InputWidth * net.Layers[0].InputHeight)
            {
                return "Wrong Image Size";
            }
            if (net.Layers.Count == 0)
            {
                return "Network is not created";
            }
            if (!isNetLearned)
            {
                return "Network is not learned or not loaded";
            }
            var dataShape = new Shape(net.Layers[0].InputWidth, net.Layers[0].InputHeight, 1, 1);
            var data = new double[dataShape.TotalLength];
            var dataVolume = BuilderInstance.Volume.From(data, dataShape);

            var j = 0;
            for (var y = 0; y < net.Layers[0].InputWidth; y++)
            {
                for (var x = 0; x < net.Layers[0].InputHeight; x++)
                {
                    dataVolume.Set(x, y, 0, 0, image[j++]);
                }
            }
            net.Forward(dataVolume);
            var prediction = net.GetPrediction();
            return GetClassNameFromNumber(prediction[0]);
        }

        public string[] RecognizeAll( byte[] image)
        {
            int count = 10;
            string[] result = new string[count];
            for (var i = 0; i < count; i++)
            {
                if (image.Length != 32 * 32)
                {
                    return result;
                }
                if (net.Layers.Count == 0)
                {
                    this.CreateCNN();
                    LoadCNN(path);
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
                 
                result[i] = GetClassNameFromNumber(prediction[0]);
            }
            return result;
        }

        private void Train(Volume<double> x, Volume<double> y, int[] labels)
        {
            this.trainer.Train(x, y);

            Test(x, labels, this.trainAccWindow, false);

            stepCount += labels.Length;
        }

        public int GetLayersCount()
        {
            return net.Layers.Count;
        }

        public int GetClassesCount()
        {
            return this.classes;
        }

        public double GetAccuracy()
        {
            return Acc;
        }

        public bool Reset()
        {
            return false;
        }

        public bool IsLearned()
        {
            return this.isNetLearned;
        }

        public string GetClassNameFromNumber(int n)
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
                    return "Warning Sign";
                case 8:
                    return "Sleeping policeman";
                case 9:
                    return "Road Works";
                case 10:
                    return "Only forward";
                case 11:
                    return "Pesh Perehod";
                default:
                    break;

            }
            return "";  
        }
    }
}