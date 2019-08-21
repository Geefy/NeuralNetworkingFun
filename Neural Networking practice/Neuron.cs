using System;
using System.Collections.Generic;
using System.Text;

namespace Neural_Networking_practice
{
    class Neuron
    {
        public float[] Weight { get; set; }
        public float[] Value { get; set; }

        public Neuron(float[] value, float[] weight)
        {
            this.Weight = weight;
            this.Value = value;
        }
    }
}
