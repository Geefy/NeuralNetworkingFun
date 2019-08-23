using System;
using System.Collections.Generic;
using System.Text;

namespace Neural_Networking_practice
{
    class Network
    {
        Random rnd = new Random(DateTime.Now.Millisecond);

        public static float[,] hoursSleepStudy = new float[,] { { 3, 5 }, { 5, 1 }, { 10, 2 } };
        public float[,] z2;
        public float[,] w1;
        public float[,] a2;
        public float[,] w2;
        public float[,] z3;
        public float[,] dJdW1;
        public float[,] dJdW2;
        public float cost1;
        public float cost2;
        public float cost3;
        public float scalar = 3;
        float[,] score = new float[3,1] { { 0.75f }, { 0.82f }, { 0.93f } };
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
            this.w1 = Weight1Struct();
            this.w2 = Weight2Struct();
        }

        public float[,] ForwardPropogate(float[,] x)
        {
            
            this.z2 = Maths.Dot(x, w1);
            this.a2 = Maths.Sigmoid(this.z2);
            this.z3 = Maths.Dot(a2, w2);
            float[,] yHat = Maths.Sigmoid(z3);

            return yHat;
        }
        /// <summary>
        /// Construct random weights
        /// </summary>
        /// <param name="input"></param>
        /// <param name="hidden"></param>
        /// <returns></returns>
        public float[,] Weight1Struct()
        {

            float[,] w = new float[inputLayer.Neurons.Length, hiddenLayer[0].Neurons.Length];
            for (int i = 0; i < w.GetLength(0); i++)
            {
                for (int j = 0; j < w.GetLength(1); j++)
                {

                    w[i, j] = Rnd(1, 10);
                }
            }
            return w;
        }

        public float[,] Weight2Struct()
        {
            float[,] w = new float[hiddenLayer[0].Neurons.Length, outputLayer.Neurons.Length];
            for (int i = 0; i < w.GetLength(0); i++)
            {
                for (int j = 0; j < w.GetLength(1); j++)
                {

                    w[i, j] = Rnd((float)rnd.Next(1,5), (float)rnd.Next(5,10));
                }
            }
            return w;
        }
        public float Rnd(float a, float b)
        {
            return a / b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public float CostFunction(float[,] x)
        {
            float[,] yHat = ForwardPropogate(x);
            float[] nArr = new float[yHat.GetLength(0)];
            float cost = 0;
            for (int i = 0; i < yHat.GetLength(0); i++)
            {
                for (int j = 0; j < yHat.GetLength(1); j++)
                {

                    nArr[i] = (float)Math.Pow((score[i,j] - yHat[i,j] ), 2);
                }

            }
            for (int i = 0; i < nArr.Length; i++)
            {
                cost += nArr[i];
            }

            return cost * 0.5f;
        }

        /// <summary>
        /// Get dirivative by weight1 and weight2
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public void CostFunctionPrime(float[,] x)
        {
            float[,] yHat = ForwardPropogate(x);
            float[,] nArr = new float[yHat.GetLength(0), yHat.GetLength(1)];
            float[,] tempD2 = new float[nArr.GetLength(0), x.GetLength(1)];
            for (int i = 0; i < yHat.GetLength(0); i++)
            {
                for (int j = 0; j < yHat.GetLength(1); j++)
                {

                    nArr[i,j] = -(score[i,j] - yHat[i,j]) * Maths.SigmoidPrime(z3[i, j]);
                }

            }
            tempD2 = Maths.Dot(nArr, w2);
            for (int i = 0; i < tempD2.GetLength(0); i++)
            {
                for (int j = 0; j < tempD2.GetLength(1); j++)
                {
                    tempD2[i, j] = tempD2[i,j] * Maths.SigmoidPrime(z2[i, j]);
                }
            }
            dJdW2 = Maths.Dot(a2, nArr);
            dJdW1 = Maths.Dot(tempD2, x);
        }



    }
}
