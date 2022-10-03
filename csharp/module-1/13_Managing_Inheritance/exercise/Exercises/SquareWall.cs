using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class SquareWall : RectangleWall
    {
        public int SideLength { get; }
        public SquareWall(string name, string color, int length): base (name, color, length, length)
        {
            SideLength = length;

        }

        public override int GetArea()
        {
            return SideLength * SideLength;
        }

        public override string ToString()
        {
            return $"{Name} ({SideLength}x{SideLength}) square";
        }
    }
}
