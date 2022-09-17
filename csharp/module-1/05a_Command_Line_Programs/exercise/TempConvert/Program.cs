using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter Program!");
            Console.WriteLine("What temperature type will you be inputting? Please input a C, a K, or an F.");
            string typeOfTemp = Console.ReadLine();
            double tempPreConvert = 0;


            do
            {
                if (typeOfTemp == "F" || typeOfTemp == "K" || typeOfTemp == "C")
                {
                    Console.WriteLine("What is the temperature in " + typeOfTemp + "?");
                    string theTemp = Console.ReadLine();
                    tempPreConvert = double.Parse(theTemp);

                    if (typeOfTemp == "F")
                    {
                        Console.WriteLine("What are you converting this to? K or C?");
                        string tempTypeToConvert = Console.ReadLine();
                        do
                        {
                            if (tempTypeToConvert == "K")
                            {
                                double finalTemp = Math.Round((((tempPreConvert - 32.0) / 1.8) + 273.15), 2);
                                Console.WriteLine("Your final temperature is " + finalTemp + tempTypeToConvert);
                                break;
                            }

                            if (tempTypeToConvert == "C")
                            {
                                double finalTemp = Math.Round(((tempPreConvert - 32.0) * (5.0 / 9.0)), 2);
                                Console.WriteLine("Your final temperature is " + finalTemp + tempTypeToConvert);
                                break;
                            }
                        }

                        while (tempTypeToConvert == "K" || tempTypeToConvert == "C");

                        break;


                    }
                    if (typeOfTemp == "C")
                    {
                        Console.WriteLine("What are you converting this to? F or K?");
                        string tempTypeToConvert = Console.ReadLine();
                        do
                        {
                            if (tempTypeToConvert == "F")
                            {
                                double finalTemp = Math.Round(((tempPreConvert * (9.0 / 5.0)) + 32), 2);
                                Console.WriteLine("Your final temperature is " + finalTemp + tempTypeToConvert);
                                break;
                            }

                            if (tempTypeToConvert == "K")
                            {
                                double finalTemp = Math.Round((tempPreConvert + 273.15),2);
                                Console.WriteLine("Your final temperature is " + finalTemp + tempTypeToConvert);
                                break;
                            }
                        }

                        while (tempTypeToConvert == "F" || tempTypeToConvert == "K");
                        break;
                    }

                    if (typeOfTemp == "K")
                    {
                        Console.WriteLine("What are you converting this to? F or C?");
                        string tempTypeToConvert = Console.ReadLine();
                        do
                        {
                            if (tempTypeToConvert == "F")
                            {
                                double finalTemp = Math.Round((1.8 * (tempPreConvert - 273.15) + 32.0),2);
                                Console.WriteLine("Your final temperature is " + finalTemp + tempTypeToConvert);
                                break;
                            }

                            if (tempTypeToConvert == "C")
                            {
                                double finalTemp = Math.Round((tempPreConvert - 273.15),2);
                                Console.WriteLine("Your final temperature is " + finalTemp + tempTypeToConvert);
                                break;
                            }
                        }

                        while (tempTypeToConvert == "F" || tempTypeToConvert == "C");
                        break;
                    }

                }
            }
            while (typeOfTemp == "F" || typeOfTemp == "K" || typeOfTemp == "C");
        }
    }
}
