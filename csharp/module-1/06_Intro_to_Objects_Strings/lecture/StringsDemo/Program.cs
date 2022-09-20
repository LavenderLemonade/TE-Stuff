using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char).
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            char blue = name[0];
            char red = name[11];
            Console.WriteLine($"First and Last : {blue} , {red}, ");

            // Console.WriteLine("First and Last Character. ");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada
            string green = name.Substring(0, 3);
            Console.WriteLine($"The first three letters of her name: {green} ");


            // Console.WriteLine("First 3 characters: ");

            // 3. Now print out the first three and the last three characters
            // Output: Adaace

            string pink = name.Substring(0, 3);
            string black = name.Substring(9, 3);
            Console.WriteLine(pink + black);

            // Console.WriteLine("Last 3 characters: ");

            // 4. What about the last word?
            // Output: Lovelace

            string[] velvet = name.Split(" ", 2);
            Console.WriteLine(velvet[1]);

            // Console.WriteLine("Last Word: ");

            // 5. Does the string contain inside of it "Love"?
            // Output: true
            bool violet = name.Contains("Love");
            Console.WriteLine($"Contains \"Love\": {violet}"); // escape characters \ let us have the quotes in the string
            // Console.WriteLine("Contains \"Love\"");

            // 6. Where does the string "lace" show up in name?
            // Output: 8
            int orange = name.IndexOf("lace");
            Console.WriteLine(orange);

            // Console.WriteLine("Index of \"lace\": ");

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            int counter = 0;
            for (int i =0; i < name.Length; i++)
            {
                if (name[i] == 'A' || name[i] == 'a')
                {
                    counter++;
                }
            }
            Console.WriteLine($"The amount of a's and A's we have is: {counter} ");

            // Console.WriteLine("Number of \"a's\": ");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            string yellow = name.Replace("Ada", "Ada, Countess of Lovelace");
            Console.WriteLine(yellow);

            // Console.WriteLine(name);

            // 9. Set name equal to null.

            name = null;

            // 10. If name is equal to null or "", print out "All Done".

            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("All Done!");
            }

            Console.ReadLine();
        }
    }
}