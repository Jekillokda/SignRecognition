using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ConvNeuronNet
{
    class InputLayer
    {
        public InputLayer(NetworkMode nm)
        {
            System.Drawing.Bitmap bitmap;
            switch (nm)
            {
                case NetworkMode.Train:
                    // bitmap = Properties.Resources.trainset;
                    bitmap = null;//!
                    for (int y = 0; y < bitmap.Height / 32; ++y)
                        for (int x = 0; x < bitmap.Width / 32; ++x)
                        {
                            trainset[x + y * (bitmap.Width / 32)].Item2 = (byte)y;
                            trainset[x + y * (bitmap.Width / 32)].Item1 = new double[32*32];
                            for (int m = 0; m < 32; ++m)
                                for (int n = 0; n < 32; ++n)
                                {
                                    trainset[x + y * (bitmap.Width / 3)].Item1[n + 3 * m] =
                                        (bitmap.GetPixel(n + 32 * x, m + 32 * y).R +
                                        bitmap.GetPixel(n + 32 * x, m + 32 * y).G +
                                        bitmap.GetPixel(n + 32 * x, m + 32 * y).B) / (765.0d);
                                }
                        }
                    //перетасовка обучающей выборки методом Фишера-Йетса
                    for (int n = Trainset.Length - 1; n >= 1; --n)
                    {
                        int j = random.Next(n + 1);
                        (double[], byte) temp = trainset[n];
                        trainset[n] = trainset[j];
                        trainset[j] = temp;
                    }
                    break;
                case NetworkMode.Test:
                    // bitmap = Properties.Resources.testset;
                    bitmap = null;//!
                    for (int y = 0; y < bitmap.Height / 32; ++y)
                        for (int x = 0; x < bitmap.Width / 32; ++x)
                        {
                            testset[x + y * (bitmap.Width / 32)] = new double[32 * 32];
                            for (int m = 0; m < 32; ++m)
                                for (int n = 0; n < 32; ++n)
                                {
                                    testset[x + y * (bitmap.Width / 32)][n + 32 * m] =
                                        (bitmap.GetPixel(n + 32 * x, m + 32 * y).R +
                                        bitmap.GetPixel(n + 32 * x, m + 32 * y).G +
                                        bitmap.GetPixel(n + 32 * x, m + 32 * y).B) / (765.0d);
                                }
                        }
                    break;
            }
        }

        private System.Random random = new System.Random();

        private (double[], byte)[] trainset = new (double[], byte)[100];//100 изображений в обучающей выборке
        public (double[], byte)[] Trainset { get => trainset; }

        private double[][] testset = new double[10][];//10 изображений в тестовой выборке
        public double[][] Testset { get => testset; }
    }
}
