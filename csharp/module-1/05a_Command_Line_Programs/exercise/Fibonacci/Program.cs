using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks.Dataflow;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's try the Fibonacci program!");
            Console.WriteLine("Input a number, it needs to be an integer.");
            string chosenNumber = Console.ReadLine();
            int theOneNumber = int.Parse(chosenNumber);
            int counter = 0;

            int[] fibArray = new int[Math.Abs(theOneNumber) + 2];
            fibArray[0] = 0;
            fibArray[1] = 1;

            if (theOneNumber <= 0)
            {
                int[] newArray = new int[2];
                for (int y =0; y < 2; y++)
                {
                    newArray[y] = fibArray[y];
                }
                string lessZero = string.Join(",", newArray);
                Console.WriteLine(lessZero);
            }
            if (theOneNumber == 1)
            {  
                fibArray[2] = 1;
                string isOne = string.Join(",", fibArray);
                Console.WriteLine(isOne);
            }

            for (int i =2; fibArray[i-1] + fibArray[i-2] <= theOneNumber; i++)
            {
                fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
            }

            for (int j = 0; j < theOneNumber; j++)
            {
                if (fibArray[j] != 0 && fibArray[j] <= theOneNumber)
                {
                    counter++;
                }
            }

            int[] finArray = new int[counter];

            for (int z = 0; z < counter; z++)
            {
                finArray[z] = fibArray[z];
            }

            string green = string.Join(",", finArray);
            Console.WriteLine(green);
        }
    }
}
