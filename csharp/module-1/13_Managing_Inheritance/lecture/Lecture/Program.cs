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

            Cat Garfield = new Cat();
            Garfield.Sleep(true);
            Garfield.Eat();
            Console.WriteLine(Garfield.Eat());

            ShaggyCow Doofus = new ShaggyCow();
            Console.WriteLine(Doofus.Sound);

            ISingable[] singables = new ISingable[]
            {
                new Cow(), new Chicken(), new Pig(), new Tractor(), Garfield
            };

            foreach(ISingable singable in singables)
            {
                Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
                Console.WriteLine("And on his farm he had a " + singable.Name + ", ee ay ee ay oh!");
                Console.WriteLine("With a " + singable.Sound + " " + singable.Sound + " here");
                Console.WriteLine("And a " + singable.Sound + " " + singable.Sound + " there");
                Console.WriteLine("Here a " + singable.Sound + " there a " + singable.Sound + " everywhere a " + singable.Sound + " " + singable.Sound);
                Console.WriteLine();
            }

            ISellable[] sellables = new ISellable[]
            {
                new Cow(), new Pig(), new Egg()
            };

            foreach(ISellable sellable in sellables)
            {
                Console.WriteLine("Step right up and get your " + sellable.Name);
                Console.WriteLine("Only $" + sellable.Price);
            }

            
            
        }
    }
}