using System;
using System.Collections.Generic;
using System.Text;

namespace Neural_Networking_practice
{
    class Network
    {

        public static float[,] hoursSleepStudy = new float[,] { { 1, 10 }, { 100, 1000 }, { 10000, 100000 } };
        public static float[,] score = new float[,] { { 1, 2, 3 }, { 4, 5 , 6 } };
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

        public float ForwardPropogate(float[,] x)
        {
            foreach (Neuron neuro in inputLayer.Neurons)
            {
                for (int i = 0; i < x.GetLength(0); i++)
                {

                }
            }

            return 0;
        }


    }
}
