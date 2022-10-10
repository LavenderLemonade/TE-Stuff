using System;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
		public static void Main(string[] args)
		{
            

            //We need to find what we're looking for
            Console.WriteLine("What word are you going to be looking for?");
            string searchWord = Console.ReadLine();

            //We need to find 
            Console.WriteLine("What word are you going to replace " + searchWord + " with?");
            string replacementWord = Console.ReadLine();
            //Where the file at?
            Console.WriteLine("Where the first file at my dude?");
            string thePath = Console.ReadLine();

            Console.WriteLine("What do you want to name your output file? Please end with .txt.");
            string outputFile = Console.ReadLine();

            string directoryPath = Environment.CurrentDirectory;

            string fullSecondPath = Path.Combine(directoryPath, outputFile);
            string firstPath = Path.Combine(directoryPath, thePath);

            try
            {
                using (StreamReader mariaReading = new StreamReader(firstPath))
                {
                    using (StreamWriter danWriting = new StreamWriter(fullSecondPath, true))
                    {
                        while (!mariaReading.EndOfStream)
                        {
                            string currentLine = mariaReading.ReadLine();
                            string fixedError = currentLine.Replace(searchWord, replacementWord);
                            danWriting.WriteLine(fixedError);
                        }
                    }

                }
                


            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
