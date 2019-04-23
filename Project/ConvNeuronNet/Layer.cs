using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project.ConvNeuronNet
{
    abstract class Layer
    {
        protected Layer(int numberofneurons, int numberofprevneurons, NeuronType neurontype, string type)
        {
            neuronsCount = numberofneurons;
            neuronsprevCount = numberofprevneurons;
            Neurons = new Neuron[numberofneurons];
            double[,] Weights = WeightInitialize(XMLAccessMode.GET, type);
            lastdeltaweights = Weights;
            for (int i = 0; i < numberofneurons; ++i)
            {
                double[] temp_weights = new double[numberofprevneurons];
                for (int j = 0; j < numberofprevneurons; ++j)
                    temp_weights[j] = Weights[i, j];
                Neurons[i] = new Neuron(null, temp_weights, neurontype);
            }
        }
        protected int neuronsCount;
        protected int neuronsprevCount;
        protected const double learningRate = 0.005d;//скорость обучения
        protected const double momentum = 0.03d;//момент инерции
        protected double[,] lastdeltaweights;//веса предыдущей итерации обучения
        Neuron[] neurons;
        public Neuron[] Neurons { get => neurons; set => neurons = value; }
        public double[] Data//я подал null на входы нейронов, так как
        {//сначала нужно будет преобразовать информацию
            set//(видео, изображения, etc.)
            {//а загружать input'ы нейронов слоя надо не сразу,
                for (int i = 0; i < Neurons.Length; ++i)
                {
                    Neurons[i].Inputs = value;
                    Neurons[i].Activator(Neurons[i].Inputs, Neurons[i].Weights);
                }
            }//а только после вычисления выходов предыдущего слоя
        }
        public double[,] WeightInitialize(XMLAccessMode accMode, string type)
        {
            double[,] weights = new double[neuronsCount, neuronsprevCount + 1];
            XmlDocument memory_doc = new XmlDocument();
            memory_doc.Load(System.IO.Path.Combine("Resources", $"{type}_memory.xml"));
            XmlElement memory_el = memory_doc.DocumentElement;
            switch (accMode)
            {
                case XMLAccessMode.GET:
                    for (int l = 0; l < weights.GetLength(0); ++l)
                        for (int k = 0; k < weights.GetLength(1); ++k)
                            weights[l, k] = double.Parse(memory_el.ChildNodes.Item(k + weights.GetLength(1) * l).InnerText.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);//parsing stuff
                    break;
                case XMLAccessMode.SET:
                    for (int l = 0; l < neuronsCount; ++l)
                        for (int k = 0; k < neuronsprevCount + 1; ++k)
                            memory_el.ChildNodes.Item(k + (neuronsprevCount + 1) * l).InnerText = Neurons[l].Weights[k].ToString();
                    break;
            }
            memory_doc.Save(System.IO.Path.Combine("Resources", $"{type}_memory.xml"));
            return weights;
        }
        abstract public void Recognize(CNN net, Layer nextLayer);//для прямых проходов
        abstract public double[] BackwardPass(double[] stuff);//и обратных
    }
}
