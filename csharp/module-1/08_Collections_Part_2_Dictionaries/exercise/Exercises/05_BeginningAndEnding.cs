using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array,
         * there is a key of its first character with the value of its last character.
         *
         * BeginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * BeginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * BeginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            if (words.Length > 0)
            {
                Dictionary<string, string> thoseThings = new Dictionary<string, string>();

                for (int i =0; i < words.Length; i++)
                {
                    string firstLetter = words[i].Substring(0, 1);
                    string secondLetter = words[i].Substring((words[i].Length - 1),1 );
                    thoseThings[firstLetter] = secondLetter;
                }
                return thoseThings;
            }
            return null;
        }
    }
}
