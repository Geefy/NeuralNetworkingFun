using System;
using System.Collections.Generic;
using System.Text;

namespace Neural_Networking_practice
{
    class Layer
    {
        public Neuron[] Neurons { get; set; }
        public Layer(int neuronCount)
        {
            this.Neurons = new Neuron[neuronCount];
        }


    }
}
