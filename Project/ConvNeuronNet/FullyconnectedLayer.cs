using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ConvNeuronNet
{
    class FullyconnectedLayer : Layer
    {
        public FullyconnectedLayer(int non, int nopn, NeuronType nt, string type) : base(non, nopn, nt, type) { }
        public override void Recognize(CNN net, Layer nextLayer)
        {
            /*double[] hidden_out = new double[Neurons.Length];
            for (int i = 0; i < Neurons.Length; ++i)
                hidden_out[i] = Neurons[i].Output;
            nextLayer.Data = hidden_out;*/
        }
        public override double[] BackwardPass(double[] gr_sums)
        {
            double[] gr_sum = null;
            //сюда можно всунуть вычисление градиентных сумм для других скрытых слоёв
            //но градиенты будут вычисляться по-другому, то есть
            //через градиентные суммы следующего слоя и производные
            /*for (int i = 0; i < neuronsCount; ++i)
                for (int n = 0; n < neuronsprevCount; ++n)
                    Neurons[i].Weights[n] += learningRate * Neurons[i].Inputs[n] * Neurons[i].Gradientor(0, Neurons[i].Derivativator(Neurons[i].Output), gr_sums[i]);*///коррекция весов
            return gr_sum;
        }
    }
}
