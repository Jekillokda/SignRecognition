﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ConvNeuronNet
{
    class OutputLayer : Layer
    {
        public OutputLayer(int non, int nopn, NeuronType nt, string type) : base(non, nopn, nt, type) { }
        public override void Recognize(CNN net, Layer nextLayer)
        {
            double e_sum = 0;
            for (int i = 0; i < Neurons.Length; ++i)
                e_sum += Neurons[i].Output;
            for (int i = 0; i < Neurons.Length; ++i)
                net.Results[i] = Neurons[i].Output / e_sum;
        }
        public override double[] BackwardPass(double[] errors)
        {
            double[] gr_sum = new double[neuronsprevCount + 1];
            for (int j = 0; j < gr_sum.Length; ++j)//вычисление градиентных сумм выходного слоя
            {
                double sum = 0;
                for (int k = 0; k < Neurons.Length; ++k)
                    sum += Neurons[k].Weights[j] * errors[k];
                gr_sum[j] = sum;
            }
            for (int i = 0; i < neuronsCount; ++i)
                for (int n = 0; n < neuronsprevCount + 1; ++n)
                {
                    double deltaw = (n == 0) ? (momentum * lastdeltaweights[i, 0] + learningRate * errors[i]) : (momentum * lastdeltaweights[i, n] + learningRate * Neurons[i].Inputs[n - 1] * errors[i]);
                    lastdeltaweights[i, n] = deltaw;
                    Neurons[i].Weights[n] += deltaw;//коррекция весов
                }
            return gr_sum;
        }
    }
}