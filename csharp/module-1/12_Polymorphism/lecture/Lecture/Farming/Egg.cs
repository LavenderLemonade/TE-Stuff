using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Egg: ISellable
    {
        public string Name { get; }
        public decimal Price { get; }
        public Egg()
        {
            Name = "Egg";
            Price = 0.25M;
        }
    }
}
