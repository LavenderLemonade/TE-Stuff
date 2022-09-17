using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningSum = 1;
            int[] fibSeq = new int[34];
            fibSeq[0] = 0;
            fibSeq[1] = 1;
            Console.WriteLine("Yo, welcome to the Fibonaci Sequence Generator!");
            Console.WriteLine("Give me a number you'd like to see the Fibonacci Sequence of. Keep it to ints plz.");

            for (int i = 2; runningSum <= 34; i++)
            {
                runningSum += fibSeq[i-1] + runningSum;
                fibSeq[i] = runningSum;
            }
            string blue = string.Join("", fibSeq);
            Console.WriteLine(blue);

        }
    }
}
