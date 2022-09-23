using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DeckOfCards.Stubs
{
    class WoodenPencil
    {
        // Class Variables and Properties 

        //Static Modifier - May be public or private, usually const but doesn't have to be 

        //All wooden pencils have a "fixed" set of default values
        // for length, shape, hardness, color. External code should be able
        // to ask WoodenPencil for these defaults


        // All wooden pencils have a minimul length below which they are
        // considered a stub and should be discarded

        //all wooden pencils have a minimum sharpness below which they are too dull and need to be sharpened

        // since we don't want these changing, we throw a const in front of them all 

        //static means that the information belongs to the class
        // it is shared across all members of the class

        //read-only means it cannot be altered outside of the class
        // once it is set, it cannot be changed

        public const double DefaultLength = 8.0;
        public const int DefaultShape = 2;
        public const string DefaultHardness = "HB";
        public static readonly Color DefaultColor = Color.Yellow;
        public const double DefaultStubLength = 2.0;
        public const double DefaultMaxDullness = 0.3;


        private static double stubLength = DefaultStubLength; //when a pencil is considered a stub, in inches 
        // private means it is only accessible inside the class

        public double Length { get; set; }
    }
}
