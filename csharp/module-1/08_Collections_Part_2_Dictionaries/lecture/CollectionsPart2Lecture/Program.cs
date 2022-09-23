using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			Console.WriteLine();

			//Declaring a Dictionary 

			Dictionary<string, string> nameToZip = new Dictionary<string, string>();

			//Adding an item to a Dictionary

			nameToZip["David"] = "44120";   // telling it that we slapping the key in and then saying what value we got 
			nameToZip["Tori"] = "44102";    // if we did nameToZip.Add("David", "44120"), it'll be unhappy because that key already exists
			nameToZip["Ben"] = "44221";
			// Grabbing Values from a Dictionary
			Console.WriteLine("David lives in " + nameToZip["David"]); //we use keys rather than indexes to find our values

			//let's start sluping up these keys from the Dictionary

			IEnumerable<string> keys = nameToZip.Keys; //slurps up and slaps down all the keys in the Dictionary 
			// is just an ordered collection that's pulled from the Dictionary we created and defined

			foreach(string keyName in keys)
            {
                Console.WriteLine(keyName + " lives in " + nameToZip[keyName]);
            }

            // let's check to see if a key is in the dictionary 

            if (nameToZip.ContainsKey("David"))
            {
                Console.WriteLine("David is there!");
            }
            Console.WriteLine();

			//Update David's Zip Code to "12345"

			nameToZip["David"] = "12345";

			foreach(KeyValuePair<string, string> nameZip in nameToZip)
            {
                Console.WriteLine(nameZip.Key + " lives in " + nameZip.Value);
            }

			//what if I wanted to remove some stuff from the Dictionary 

			nameToZip.Remove("Tori");
            Console.WriteLine("Removed Tori");
            Console.WriteLine();

			//tossing the stuff in the Dictionary into a string 

			foreach(KeyValuePair<string, string> nameZip in nameToZip)
            {
                Console.WriteLine($"Key: {nameZip.Key}, Value: {nameZip.Value}");
            }
			

			//what if I felt like getting, like, ALL the values from the dictionary?

			IEnumerable<string> values = nameToZip.Values;
            Console.WriteLine(values);

			//Initialize a Dictionary 

			Dictionary<string, string> studentNames = new Dictionary<string, string>()
			{
				{"Tracy", "Barry" }, {"Colin", "Detwiler" }, {"Kim", "Barry" }, {"Maria G", "Garcia" }, {"Amy", "Drapac" }, {"Ben", "Measor" }, {"Joe", "Gibson" }, {"Alex", "Hewson" }
			};

			//Debugging 


		}

	}
}
