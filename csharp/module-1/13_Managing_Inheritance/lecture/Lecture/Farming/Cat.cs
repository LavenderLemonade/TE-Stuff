using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Cat: FarmAnimal
    {
        public Cat(): base("Cat", "meow")
        {

        }

        public override string Eat()
        {
            return "mmmm mmmm LASAGNA";
        }

        //public override string Sound
        //{
        //    get
        //    {
        //        return "meow";
        //    }
        //}
    }
}
