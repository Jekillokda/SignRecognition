﻿using ConvNetSharp.Volume;
using ConvNetSharp.Volume.Double;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ConvNeuronNet
{
    internal class DataSet
    {
        private readonly List<ImageEntry> trainImages;
        private readonly Random random = new Random(RandomUtilities.Seed);
        private int start;
        private int epochCompleted;

        public DataSet(List<ImageEntry> trainImages)
        {
            this.trainImages = trainImages;
        }

        public Tuple<Volume<double>, Volume<double>, int[]> NextBatch(int batchSize)
        {
            const int w = 28;
            const int h = 28;
            const int numClasses = 10;

            var dataShape = new Shape(w, h, 1, batchSize);
            var labelShape = new Shape(1, 1, numClasses, batchSize);
            var data = new double[dataShape.TotalLength];
            var label = new double[labelShape.TotalLength];
            var labels = new int[batchSize];

            // Shuffle for the first epoch
            if (this.start == 0 && this.epochCompleted == 0)
            {
                for (var i = this.trainImages.Count - 1; i >= 0; i--)
                {
                    var j = random.Next(i);
                    var temp = trainImages[j];
                    this.trainImages[j] = this.trainImages[i];
                    this.trainImages[i] = temp;
                }
            }

            var dataVolume = BuilderInstance.Volume.From(data, dataShape);

            for (var i = 0; i < batchSize; i++)
            {
                var entry = trainImages[this.start];

                labels[i] = entry.Label;

                var j = 0;
                for (var y = 0; y < h; y++)
                {
                    for (var x = 0; x < w; x++)
                    {
                        dataVolume.Set(x, y, 0, i, entry.Image[j++] / 255.0);
                    }
                }

                label[i * numClasses + entry.Label] = 1.0;

                start++;
                if (start == trainImages.Count)
                {
                    start = 0;
                    epochCompleted++;
                    Console.WriteLine($"Epoch #{this.epochCompleted}");
                }
            }


            var labelVolume = BuilderInstance.Volume.From(label, labelShape);

            return new Tuple<Volume<double>, Volume<double>, int[]>(dataVolume, labelVolume, labels);
        }
    }
}
