using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {  
            //1. Ask the user for the file path
            Console.WriteLine("Heyo, give me a file pathway!");
            string fullPath = Console.ReadLine();
            //2. Ask the user for the search string
            Console.WriteLine("Yo, what word do you want to search for?");
            string theQuery = Console.ReadLine();
            // Ask the user if they want to be case sensitive
            Console.WriteLine("Do you want to be case-sensitive? Y/N");
            string choice = Console.ReadLine();
            //if statement 
            if (choice.ToUpper() == "N")
            {
                try
                {
                    int counter = 1;
                    //Open a StreamReader with the using statement
                    using (StreamReader sr = new StreamReader(fullPath))
                    {
                        // Read the file until the end of the stream is reached
                        // EndOfStream is a "marker" that the stream uses to determine
                        // if it has reached the end
                        // As we read forward the marker moves forward like a typewriter.
                        while (!sr.EndOfStream)
                        {

                            // Read in the line
                            string line = sr.ReadLine();
                            string lineUp = line.ToUpper();
                            string queryUpper = theQuery.ToUpper();
                            
                            
                            if (lineUp.Contains(queryUpper))
                            {
                                Console.WriteLine(counter + ") " + line);
                                
                            }
                            // Print it to the screen
                            counter++;

                        }
                    }
                }
                catch (IOException e) //catch a specific type of Exception
                {
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(e.Message);
                }
            }
            //3. Open the file
            else if (choice.ToUpper() == "Y")
            {
                try
                {
                    int counter = 0;
                    //Open a StreamReader with the using statement
                    using (StreamReader sr = new StreamReader(fullPath))
                    {
                        // Read the file until the end of the stream is reached
                        // EndOfStream is a "marker" that the stream uses to determine
                        // if it has reached the end
                        // As we read forward the marker moves forward like a typewriter.
                        while (!sr.EndOfStream)
                        {

                            // Read in the line
                            string line = sr.ReadLine();
                            counter++;
                            if (line.Contains(theQuery))
                            {
                                Console.WriteLine(counter + ") " + line);

                            }
                            // Print it to the screen

                        }
                    }
                }
                catch (IOException e) //catch a specific type of Exception
                {
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(e.Message);
                }

            }
            
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number
        }
    }
}
