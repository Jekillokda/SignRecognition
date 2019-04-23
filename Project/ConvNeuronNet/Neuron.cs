using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ConvNeuronNet
{
    class Neuron
    {
        public Neuron(double[] inputs, double[] weights, NeuronType type)
        {
            this.type = type;
            this.weights = weights;
            this.inputs = inputs;
        }
        private NeuronType type;//тип нейрона
        private double[] weights;//его веса
        private double[] inputs;//его входы
        private double output;//его выход
        private double derivative;
        //константы для функции активации
        private double a = 0.01d;
        public double[] Weights { get => weights; set => weights = value; }
        public double[] Inputs { get => inputs; set => inputs = value; }
        public double Output { get => output; }
        public double Derivative { get => derivative; }
        public void Activator(double[] i, double[] w)//нелинейные преобразования
        {
            double sum = w[0];//аффиное преобразование через смещение(нулевой вес)
            for (int l = 0; l < i.Length; ++l)
                sum += i[l] * w[l + 1];//линейные преобразования
            switch (type)
            {
                case NeuronType.Convolutional://для нейронов скрытого (свёртки) слоя
                    output = LeakyReLU(sum);
                    derivative = LeakyReLU_Derivativator(sum);
                    break;
                case NeuronType.Fullyconnected://для нейронов полносвязного слоя
                    break;
                case NeuronType.Output://для нейронов выходного слоя
                    output = Math.Exp(sum);
                    break;
            }
        }
        private double LeakyReLU(double sum) => (sum >= 0) ? sum : a * sum;
        private double LeakyReLU_Derivativator(double sum) => (sum >= 0) ? 1 : a;
    }
}