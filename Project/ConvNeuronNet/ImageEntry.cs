using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ConvNeuronNet
{
    public class ImageEntry
    {
        public byte[] Image { get; set; }

        public int Label { get; set; }

        public override string ToString()
        {
            return "Label: " + Label;
        }
    }
}
