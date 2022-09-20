using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {

			double[] avgScores = new double[20];
			avgScores[0] = 3.0;


			string[] teStaff = new string[6];
			teStaff[0] = "David";
			teStaff[1] = "Tori";
			teStaff[2] = "John";
			teStaff[3] = "Ben";
			teStaff[4] = "Kaitlyn";
			teStaff[5] = "Chelsea";





			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");

			List<string> names = new List<string>();
			names.Add("Frodo");
			names.Add("Sam");
			names.Add("Pippin");
			names.Add("Merry");
			names.Add("Gandalf");
			names.Add("Aragorn, Son of Arathorn");
			names.Add("Boromir, Son of Denethor");
			names.Add("Gimli");
			names.Add("Legolas");


			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			for (int i = 0; i < names.Count; i++)
            {
				Console.WriteLine(names[i]);
            }


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");

			string[] namesArray = names.ToArray();

			for (int i=0; i<namesArray.Length; i++)
            {
                Console.WriteLine(namesArray[i]);
            }


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");

			names.Sort();
			for (int i = 0; i < names.Count; i++)
            {
				Console.WriteLine(names[i]);
            }


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");

			names.Reverse();

			for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }


			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

			foreach (string name in names)
            {
				Console.WriteLine(name);
            }

			string word = "TechElevator";
			foreach(char letter in word)
            {
                Console.WriteLine(letter);
            }


			Console.WriteLine("########################## Collections with Classes ################################");

			List<Dog> dogs = new List<Dog>();

			Dog davidsdog = new Dog();
			davidsdog.Name = "Jerry";
			davidsdog.Age = 6;
			davidsdog.Breed = "Shepard-Mix";

			Dog zachDog = new Dog();
			zachDog.Name = "Rosy";
			zachDog.Age = 5;
			zachDog.Breed = "Pitbull";

			dogs.Add(zachDog);
			dogs.Add(davidsdog);

			foreach (Dog currentDog in dogs)
            {
				Console.WriteLine(currentDog.Name);
            }

		}
	}

    public class Dog
    {
		public string Name { get; set; }
		public int Age { get; set; }
		public string Breed { get; set; }
    }
}
