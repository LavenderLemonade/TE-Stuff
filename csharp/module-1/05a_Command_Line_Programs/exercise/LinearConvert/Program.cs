using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linear Measurement Converter!");
            Console.WriteLine("Is the measurement you're inputting going to be in feet or meters? Please input F or M?");
            string initQuery = Console.ReadLine();
            char theQuery = char.Parse(initQuery);

            do
            {
                if (theQuery == 'F' || theQuery == 'M')
                {
                    if (theQuery == 'F')
                    {
                        Console.WriteLine("What is the value in feet?");
                        string thatLength = Console.ReadLine();
                        double lengthPreConvert = double.Parse(thatLength);
                        double convertedLength = (lengthPreConvert * 0.3048);
                        Console.WriteLine("Your length is " + convertedLength + "meters!");
                        break;
                    }

                    if (theQuery == 'M')
                    {
                        Console.WriteLine("What is the value in meters?");
                        string thatLength = Console.ReadLine();
                        double lengthPreConvert = double.Parse(thatLength);
                        double convertedLength = (lengthPreConvert * 3.2808399);
                        Console.WriteLine("Your length is " + convertedLength + "meters!");
                        break;
                    }
                }

            }
            while (theQuery == 'F' || theQuery == 'M');
            
            

        }
    }
}
