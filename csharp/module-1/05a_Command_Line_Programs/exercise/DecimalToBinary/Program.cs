using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("He there, gimme a number.");
            string thisNum = Console.ReadLine();
            string[] theseNums = thisNum.Split(' ');
            

            for (int j= 0; j < theseNums.Length; j++)
            {
                double thatNum = double.Parse(theseNums[j]);
                int[] remHolder = new int[10];
                int counter = 0;
                for (int i = 0; thatNum != 0; i++)
                {
                    if (thatNum % 2 == 0)
                    {
                        remHolder[i] = 0;
                        thatNum = thatNum / 2;
                        counter++;
                    }

                    else if (thatNum % 2 == 1)
                    {
                        remHolder[i] = 1;
                        thatNum = (thatNum - 1) / 2;
                        counter++;
                    }
                }
                int[] boxLength = new int[counter];
                for (int i = 1; i < counter; i++)
                {
                    boxLength[i - 1] = remHolder[counter - i];
                }
                string green = string.Join("", boxLength);
                Console.WriteLine(green);
            }

            
            
        }
    }
}
