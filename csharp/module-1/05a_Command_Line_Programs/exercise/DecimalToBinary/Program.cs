using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tossing my counter(s) here
            int runningMod = 0;
            int counter = 0;

            //let's get this party started 
            Console.WriteLine("Yo, gimme a number to convert");
            string theQuery = Console.ReadLine();
            double newNum = double.Parse(theQuery);
            int[] keepTrack = new int[(int)(newNum)];

            for (int i= 0; newNum >= 1; i++)
            {
                if ((newNum % 2) == 0 && i == counter)
                {
                    newNum = newNum / 2.0;
                    runningMod = (int)(newNum % 2);
                    counter++;
                    keepTrack[i] = runningMod;
                    
                }

                if ((newNum % 2) == 1 && i == counter)
                {
                    runningMod = (int)(newNum % 2);
                    keepTrack[i] = runningMod;
                    newNum = (newNum - 1) / 2.0;
                    
                    counter++;
                    
                    
                }
            }

            int[] checkThat = new int[counter];
            for (int j=0; j<counter; j++)
            {
                checkThat[j] = keepTrack[counter - (j + 1)];
            }

            string green = string.Join("", checkThat);
            Console.WriteLine(green);
        }
    }
}
