using System;
using System.Collections.Generic;
using System.Text;

namespace Neural_Networking_practice
{
    class Network
    {
        Random rnd = new Random(DateTime.Now.Millisecond);

        public static float[,] hoursSleepStudy = new float[,] { { 3, 5 }, { 5, 1 }, { 10, 2 } };
        public static float[,] weight = new float[,] { { 3, 2, 3 }, { 4, 5 , 6 } };
        float[] score = new float[] { 75, 82, 93 };
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

        public float[,] ForwardPropogate(float[,] x)
        {
            float[,] z2 = Maths.Dot(x, weight);
            float[,] a2 = Maths.Sigmoid(z2);
            float[,] z3 = Maths.Dot(a2, weight);
            float[,] yHat = Maths.Sigmoid(z3);

            return yHat;
        }


    }
}
