using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         *
         * WordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * WordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * WordMultiple(["c", "c", "c", "c"]) → {"c": true}
         *
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, bool> theseWords = new Dictionary<string, bool>();
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
                        if (counter >= 2)
                        {
                            theseWords[theKey] = true;
                            counter = 1;
                        }
                        else
                        {
                            theseWords[theKey] = false;
                            counter = 1;
                        }
                        
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
                        if (counter >= 2)
                        {
                            theseWords[theKey] = true;
                            counter = 1;
                        }
                        else
                        {
                            theseWords[theKey] = false;
                            counter = 1;
                        }
                    }
                    if (i == words.Length - 1)
                    {
                        for (int w = 0; w < words.Length - 1; w++)
                        {
                            if (words[w] == words[i])
                            {
                                counter++;
                            }
                        }
                        string theKey = words[i];
                        if (counter >= 2)
                        {
                            theseWords[theKey] = true;
                            counter = 1;
                        }
                        else
                        {
                            theseWords[theKey] = false;
                            counter = 1;
                        }
                    }
                }
                return theseWords;
            }
            return theseWords;
        }
    }
}
