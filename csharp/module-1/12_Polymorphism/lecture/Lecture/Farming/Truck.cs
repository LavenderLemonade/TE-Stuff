using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Truck
    {
        public string Name { get;}
        public string Sound { get;}

        public Truck()
        {
            Name = "Truck";
            Sound = "brrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr";
        }

        public void Drive()
        {
            Console.WriteLine("That's so sad. Alexa: play 'Truck Yeah' by Timm McGraw.");
        }
    }
}
