using System;
using System.IO;

namespace Lecture.Aids
{
    public static class WritingTextFiles
    {
        /*
        * This method below provides sample code for printing out a message to a text file.
        */
        public static void WritingAFile()
        {
            //I guess we're just doing this again 
            string fileDirectory = Environment.CurrentDirectory;
            string fileName = "output.txt";
            string fullPath = Path.Combine(fileDirectory, fileName);

            try
            {
                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    writer.WriteLine("Hey we here!");
                }
            }

            catch(IOException ex)
            {
                Console.WriteLine("You CLEARLY got something wrong bucko!");
                Console.WriteLine(ex.Message);
            }

            // After the using statement ends, file has now been written
            // and closed for further writing
        }
    }
}
