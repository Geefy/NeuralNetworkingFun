using System;

namespace Neural_Networking_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Network createtest = new Network(2,1,3,1);
            float[,] testArr = Maths.Scaling(Network.hoursSleepStudy, 12);
            float[,] result = createtest.ForwardPropogate(testArr);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.WriteLine(result[i, j]);
                }
            }
            //createtest.Testing(2, 3);
            Console.ReadKey();

        }
    }
}
