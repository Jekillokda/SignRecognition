using ConvNetSharp.Core;
using ConvNetSharp.Core.Layers.Double;
using ConvNetSharp.Core.Serialization;
using ConvNetSharp.Core.Training;
using ConvNetSharp.Volume;
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
        int Aim = 90;
        double Acc = 0;
        private SgdTrainer<double> trainer;
        string path = @"D:\road-video\CNN.txt";

        private readonly CircularBuffer<double> testAccWindow = new CircularBuffer<double>(100);
        private readonly CircularBuffer<double> trainAccWindow = new CircularBuffer<double>(100);

        public CNN()
        {
            net = new Net<double>();
        }
        public int createCNN(int inpx = 32, int inpy = 32, int inpd = 1)
        {
            net.AddLayer(new InputLayer(inpx, inpy, inpd));
            net.AddLayer(new ConvLayer(28, 28, 12));
            net.AddLayer(new ReluLayer());
            net.AddLayer(new PoolLayer(14, 14));
            net.AddLayer(new ConvLayer(10, 10, 24));
            net.AddLayer(new ReluLayer());
            net.AddLayer(new PoolLayer(5, 5));
            net.AddLayer(new FullyConnLayer(150));
            net.AddLayer(new DropoutLayer(0.5));
            net.AddLayer(new FullyConnLayer(100));
            net.AddLayer(new DropoutLayer(0.5));
            net.AddLayer(new FullyConnLayer(26));
            net.AddLayer(new SoftmaxLayer(26));
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
            var datasets = new DataSets(pathL, pathT);
            if (!datasets.Load(10))
            {
                return -2;
            }
            this.trainer = new SgdTrainer<double>(this.net)
            {
                LearningRate = 0.02,
                BatchSize = 10,
                Momentum = 0.9
            };
        
            if (net.Layers.Count > 0)
            {
                stepCount = 0;
                do
                {
                    var trainSample = datasets.Train.NextBatch(trainer.BatchSize);
                    Train(trainSample.Item1, trainSample.Item2, trainSample.Item3);

                    var testSample = datasets.Test.NextBatch(trainer.BatchSize);
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
        public string loadCNN()
        {
            if (path!= "")
            {
                loadedJson = File.ReadAllText(path);
                var deserialized = SerializationExtensions.FromJson<double>(loadedJson);
                net = deserialized;
                return loadedJson;
            }
            else return "";
        }
        public double recognize(Volume<double> x)
        {
            
            return -1;
        }

        private void Train(Volume<double> x, Volume<double> y, int[] labels)
        {
            trainer.Train(x, y);

            Test(x, labels, this.trainAccWindow, false);

            stepCount += labels.Length;
        }

    }
}