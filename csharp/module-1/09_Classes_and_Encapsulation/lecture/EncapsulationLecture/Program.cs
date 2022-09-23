using EncapsulationLecture.CLasses;
using System;


namespace EncapsulationLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            person David = new person(1989);
            Dog davidsDog = new Dog("Jerry", "Separd-Mix", false);
            Dog charlieDog = new Dog("Snoopy", "Beagle", false);

            davidsDog.SpeakSound = "Ruff!";
            charlieDog.SpeakSound = "Good grief!";

            davidsDog.Speak();
            charlieDog.Speak();
        }
    }
}
