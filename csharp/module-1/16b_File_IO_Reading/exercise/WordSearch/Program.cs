using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {  
            //Ask the user for the file path
            Console.WriteLine("Heyo, give me a file pathway!");
            string fullPath = Console.ReadLine();
            //Ask the user for the search string
            Console.WriteLine("Yo, what word do you want to search for?");
            string theQuery = Console.ReadLine();
            // Ask the user if they want to be case sensitive
            Console.WriteLine("Do you want to be case-sensitive? Y/N");
            string choice = Console.ReadLine();
            //if statement: this one is important because the default is case-sensitive 
            if (choice.ToUpper() == "N")
            {
                try //
                {
                    int counter = 1; //we initialize this here because we start reading at line 1
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
                            string line = sr.ReadLine(); //this one reads the current line in the text file into a variable called line
                            string lineUp = line.ToUpper(); //this one makes an uppercase version of the line we just read
                            string queryUpper = theQuery.ToUpper(); //this one makes an uppercase version of the word the user is looking for 

                            if (lineUp.Contains(queryUpper)) //now we want to see if the uppercase line we're currently reading has the word we're looking for 
                            {
                                Console.WriteLine(counter + ") " + line); //if we find the word we're looking for, we then just print out the line number we're currently on and the original, unaltered line 
                            }
                            counter++; //right here we iterate the counter after the if statement because the while loop will keep going, and we want to record the line we're on with each time through the loop 
                        }
                    }
                }
                catch (IOException e) //catch a specific type of Exception
                {
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(e.Message);
                }
            }
            //this happens if the user wants the reader to be case-sensitive
            else if (choice.ToUpper() == "Y")
            {
                try
                {
                    int counter = 1; //again: we start here from the first line 
                    using (StreamReader sr = new StreamReader(fullPath)) //still reading from the path we provided
                    {
                        while (!sr.EndOfStream)
                        {
                            // Read in the line
                            string line = sr.ReadLine();
                            
                            if (line.Contains(theQuery)) //checking if the line has the exact word we're looking for 
                            {
                                Console.WriteLine(counter + ") " + line);
                            }
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
        }
    }
}
