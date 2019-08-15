using System;
using System.Collections.Generic;
using System.Text;

namespace Neural_Networking_practice
{
    class Network
    {

        float[,] x = new float[,] { { 3, 5 }, { 5, 1 }, { 10, 2 } };
        float[] y = new float[] { 75, 82, 93 };
        Layer inputLayer;
        Layer[] hiddenLayer;
        Layer outputLayer;

        public Network(int inputNeuronCount, int hiddenLayersCount, int hiddenNeuronCount, int outputNeuronCount)
        {
            inputLayer = new Layer(inputNeuronCount);

            hiddenLayer = new Layer[hiddenLayersCount];
            for (int i = 0; i < hiddenLayersCount; i++)
                hiddenLayer[i] = new Layer(hiddenNeuronCount);

            outputLayer = new Layer(outputNeuronCount);
        }

        public float Forward(float x)
        {
            return 0;
        }


    }
}
