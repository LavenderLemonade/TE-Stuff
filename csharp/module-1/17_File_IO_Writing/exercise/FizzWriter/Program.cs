using System;
using System.IO;

namespace FizzWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //So, we're writing to a file, but not reading from one, just writing 
            //So what we need to do is make sure we can tell the program how much we're doing this 
            //but before that, let's ask them where the file even is 
            Console.WriteLine("Hey, where do you want to save the file?");
            string destFile = Console.ReadLine();


            try
            {
                using (StreamWriter writer = new StreamWriter(destFile))
                {
                    for (int i = 1; i < 301; i++)
                    {
                        if(i % 3 == 0 && i % 5 == 0)
                        {
                            writer.WriteLine("FizzBuzz");
                        }
                        else if(i % 3 == 0)
                        {
                            writer.WriteLine("Fizz");
                        }
                        else if(i % 5 == 0)
                        {
                            writer.WriteLine("Buzz");
                        }
                        else
                        {
                            writer.WriteLine(i);
                        }
                    }

                }


            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
