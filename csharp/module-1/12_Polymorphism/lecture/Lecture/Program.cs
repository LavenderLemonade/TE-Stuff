using Lecture.Farming;
using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // OLD MACDONALD
            //
            ISingable[] singables = new ISingable[] { new Cow(), new Chicken(), new Tractor() };

            foreach (ISingable thing in singables)
            {
                Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
                Console.WriteLine("And on his farm he had a " + thing.Name + ", ee ay ee ay oh!");
                Console.WriteLine("With a " + thing.Sound + " " + thing.Sound + " here");
                Console.WriteLine("And a " + thing.Sound + " " + thing.Sound + " there");
                Console.WriteLine("Here a " + thing.Sound + " there a " + thing.Sound + " everywhere a " + thing.Sound + " " + thing.Sound);
                Console.WriteLine();
            }

            Tractor NotJohnDeere = new Tractor();
            Console.WriteLine(NotJohnDeere.Name);
            Console.WriteLine(NotJohnDeere.Sound);

            //oop here we go, selling off the farm and moving to Baltimore

            ISellable[] sellables = new ISellable[] { new Egg(), new Cow(), new Pig(), new Chicken() };
            foreach(ISellable item in sellables)
            {
                Console.WriteLine($"Please buy this {item.Name} for only {item.Price}!");
            }

            NotJohnDeere.Drive();

            Truck myTruck = new Truck();
            myTruck.Drive();

        }
    }
}