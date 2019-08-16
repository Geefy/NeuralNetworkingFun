using System;

namespace Neural_Networking_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Network createtest = new Network(2,1,3,1);

            Maths.Dot(Network.hoursSleepStudy, Network.score);
            Console.ReadKey();

        }
    }
}
