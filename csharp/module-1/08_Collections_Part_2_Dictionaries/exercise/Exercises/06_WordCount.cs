using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
         * number of times that string appears in the array.
         *
         * ** A CLASSIC **
         *
         * WordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * WordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * WordCount([]) → {}
         * WordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         *
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            Dictionary<string, int> theseWords = new Dictionary<string, int>();
            int counter = 1;

            if (words != null || words.Length != 0)
            {

                for (int i = 0; i < words.Length; i++)
                {
                    if (i == 0)
                    {
                        for (int u = i + 1; u < words.Length; u++)
                        {
                            if (words[u] == words[i])
                            {
                                counter++;
                            }
                        }
                        string theKey = words[i];
                        theseWords[theKey] = counter;
                        counter = 1;
                    }
                    if (i > 0 && i < words.Length - 1)
                    {
                        for (int k = 0; k < i; k++)
                        {
                            if (words[k] == words[i])
                            {
                                counter++;
                            }
                        }
                        for (int j = i + 1; j < words.Length; j++)
                        {
                            if (words[j] == words[i])
                            {
                                counter++;
                            }
                        }
                        string theKey = words[i];
                        theseWords[theKey] = counter;
                        counter = 1;
                    }
                    if (i == words.Length - 1)
                    {
                        for (int w = 0; w < words.Length-1; w++)
                        {
                            if (words[w] == words[i])
                            {
                                counter++;
                            }
                        }
                        string theKey = words[i];
                        theseWords[theKey] = counter;
                        counter = 1;
                    }  
                }
                return theseWords;
            }
            return theseWords;
        }
    }
}
