using System;

namespace CommandLineProgramsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a kilometer value to start at: ");
            string value = Console.ReadLine();
            int kilometerStart = int.Parse(value);
        }
    }
}
