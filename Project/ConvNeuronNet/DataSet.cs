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
        private readonly List<ImageEntry> ImagesList;
        private readonly Random random = new Random(RandomUtilities.Seed);
        private int start;
        private int epochCompleted;

        public DataSet(List<ImageEntry> trainImages)
        {
            this.ImagesList = trainImages;
        }

        public Tuple<Volume<double>, Volume<double>, int[]> NextBatch(int batchSize, int numClasses = 10)
        {
            const int w = 32;
            const int h = 32;

            var dataShape = new Shape(w, h, 1, batchSize);
            var labelShape = new Shape(1, 1, numClasses, batchSize);
            var data = new double[dataShape.TotalLength];
            var label = new double[labelShape.TotalLength];
            var labels = new int[batchSize];

            // Shuffle for the first epoch
            if (this.start == 0 && this.epochCompleted == 0)
            {
                for (var i = this.ImagesList.Count - 1; i >= 0; i--)
                {
                    var j = random.Next(i);
                    var temp = ImagesList[j];
                    this.ImagesList[j] = this.ImagesList[i];
                    this.ImagesList[i] = temp;
                }
            }

            var dataVolume = BuilderInstance.Volume.From(data, dataShape);

            for (var i = 0; i < batchSize; i++)
            {
                var entry = ImagesList[this.start];

                labels[i] = entry.Label;

                var j = 0;
                for (var y = 0; y < h; y++)
                {
                    for (var x = 0; x < w; x++)
                    {
                        dataVolume.Set(x, y, 0, i, entry.Image[j++] / 255.0);
                    }
                }
                if(i * numClasses + entry.Label<label.Length)
                label[i * numClasses + entry.Label] = 1.0;

                start++;
                if (start == ImagesList.Count)
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
