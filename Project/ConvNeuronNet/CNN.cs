using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ConvNeuronNet
{
    class CNN
    {
        public CNN(NetworkMode nm) => input_layer = new InputLayer(nm);
        //все слои сети
        private InputLayer input_layer = null;
        public ConvolutionalLayer conv_layer1 = new ConvolutionalLayer(70, 15, NeuronType.Convolutional, nameof(conv_layer1));
        public ConvolutionalLayer conv_layer2 = new ConvolutionalLayer(30, 70, NeuronType.Convolutional, nameof(conv_layer2));
        public OutputLayer output_layer = new OutputLayer(10, 30, NeuronType.Output, nameof(output_layer));
        //массив для хранения выхода сети
        public double[] Results = new double[10];
        //непосредственно обучение
        public void Train(CNN net)//backpropagation method
        {
            int epoches = 1200;
            for (int k = 0; k < epoches; ++k)
            {
                for (int i = 0; i < net.input_layer.Trainset.Length; ++i)
                {
                    //прямой проход
                    ForwardPass(net, net.input_layer.Trainset[i].Item1);
                    //вычисление ошибки по итерации
                    double[] errors = new double[net.Results.Length];
                    for (int x = 0; x < errors.Length; ++x)
                    {
                        errors[x] = (x == net.input_layer.Trainset[i].Item2) ? -(net.Results[x] - 1.0d) : -net.Results[x];
                    }
                    //обратный проход и коррекция весов
                    double[] temp_gsums1 = net.output_layer.BackwardPass(errors);
                    double[] temp_gsums2 = net.conv_layer2.BackwardPass(temp_gsums1);
                    net.conv_layer1.BackwardPass(temp_gsums2);
                }
            }

            //загрузка скорректированных весов в "память"
            net.conv_layer1.WeightInitialize(XMLAccessMode.SET, nameof(conv_layer1));
            net.conv_layer2.WeightInitialize(XMLAccessMode.SET, nameof(conv_layer2));
            net.output_layer.WeightInitialize(XMLAccessMode.SET, nameof(output_layer));
        }
        //тестирование сети
        public void Test(CNN net)
        {
            for (int i = 0; i < net.input_layer.Testset.Length; ++i)
                ForwardPass(net, net.input_layer.Testset[i]);
        }
        public void ForwardPass(CNN net, double[] netInput)
        {
            net.conv_layer1.Data = netInput;
            net.conv_layer1.Recognize(null, net.conv_layer2);
            net.conv_layer2.Recognize(null, net.output_layer);
            net.output_layer.Recognize(net, null);
        }
    }
}