using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Tractor: ISingable
    {
        public string Name { get; }
        public string Sound { get; }

        public Tractor()
        {
            Name = "Tractor";
            Sound = "Vroom";    
        }

        public void Drive()
        {
            Console.WriteLine("That's so sad. Alexa: play 'She Thinks My Tractor's Sexy' by that one country guy.");
        }

      
    }
}
