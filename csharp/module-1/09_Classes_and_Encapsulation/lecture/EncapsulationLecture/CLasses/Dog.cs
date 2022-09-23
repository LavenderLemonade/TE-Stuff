using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture.CLasses
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        private bool isSpade { get; set; }
        private string speakSound;
        public string SpeakSound
        {
            get
            {
                return speakSound;
            }
            set
            {
                this.speakSound = value;
            }
        }

        public Dog()
        {
            Console.WriteLine("Inside the Dog Constructor");
        }

        public Dog (string name, string breed, bool isSpade)
        {
            //this - looks at the current thing
            this.Name = name;
            this.Breed = breed;
            this.isSpade = isSpade;
        }

        public void Speak()
        {
            Console.WriteLine($"{ this.Name} says {this.speakSound}");
        }
    }
}
