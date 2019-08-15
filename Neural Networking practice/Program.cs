using System;

namespace Neural_Networking_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Network createtest = new Network(2,1,3,1);
            float[,] hoursSleepStudy = new float[,] { { 3, 5 }, { 5, 1 }, { 10, 2 } };
            Maths.Scaling(12, 12);
            Console.WriteLine(Maths.Sigmoid(1));
            Console.ReadKey();

        }
    }
}
