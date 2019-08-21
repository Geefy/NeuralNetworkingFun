using System;

namespace Neural_Networking_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Network NN = new Network(2,1,3,1);
            float[,] testArr = Maths.Scaling(Network.hoursSleepStudy, 12);
            NN.CostFunctionPrime(testArr);
            foreach  (float item in NN.dJdW1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("dJdW2");
            foreach  (float item in NN.dJdW2)
            {
                Console.WriteLine(item );
            }
            NN.cost1 = NN.CostFunction(testArr);
            for (int i = 0; i < NN.dJdW1.GetLength(0); i++)
            {
                for (int j = 0; j < NN.dJdW1.GetLength(1); j++)
                {
                    NN.w1[j,i] = NN.w1[j,i] + NN.scalar * NN.dJdW1[i,j];
                    
                }
            }
            for (int i = 0; i < NN.dJdW2.GetLength(0); i++)
            {
                for (int j = 0; j < NN.dJdW2.GetLength(1); j++)
                {
                    NN.w2[i, j] = NN.w2[i, j] + NN.scalar * NN.dJdW2[i, j];

                }
            }
            NN.cost2 = NN.CostFunction(testArr);
            NN.CostFunctionPrime(testArr);
            for (int i = 0; i < NN.dJdW1.GetLength(0); i++)
            {
                for (int j = 0; j < NN.dJdW1.GetLength(1); j++)
                {
                    NN.w1[j, i] = NN.w1[j, i] - NN.scalar * NN.dJdW1[i, j];

                }
            }
            for (int i = 0; i < NN.dJdW2.GetLength(0); i++)
            {
                for (int j = 0; j < NN.dJdW2.GetLength(1); j++)
                {
                    NN.w2[i, j] = NN.w2[i, j] - NN.scalar * NN.dJdW2[i, j];

                }
            }
            NN.cost3 = NN.CostFunction(testArr);
            Console.WriteLine(NN.cost1);
            Console.WriteLine(NN.cost2);
            Console.WriteLine(NN.cost3);
            Console.ReadKey();

        }
    }
}
