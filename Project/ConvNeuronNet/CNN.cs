using ConvNetSharp.Core;
using ConvNetSharp.Core.Layers;
using ConvNetSharp.Core.Layers.Double;
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
        CNN()
        {
            var net = new Net<double>();
            net.AddLayer(new InputLayer(32, 32, 1));
            net.AddLayer(new ConvLayer(28, 28, 12));
            net.AddLayer(new SoftmaxLayer(14));
            net.AddLayer(new FullyConnLayer(150));
            net.AddLayer(new DropoutLayer(0.5));
            net.AddLayer(new FullyConnLayer(100));
            net.AddLayer(new DropoutLayer(0.5));
            net.AddLayer(new FullyConnLayer(26));
            net.AddLayer(new SoftmaxLayer(42));
        }
        
    }
}