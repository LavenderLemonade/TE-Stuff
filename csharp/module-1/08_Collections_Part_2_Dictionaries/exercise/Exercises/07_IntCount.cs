using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of int values, return a Dictionary<int, int> with a key for each int, with the value the
         * number of times that int appears in the array.
         *
         * ** The lesser known cousin of the the classic WordCount **
         *
         * IntCount([1, 99, 63, 1, 55, 77, 63, 99, 63, 44]) → {1: 2, 44: 1, 55: 1, 63: 3, 77: 1, 99:2}
         * IntCount([107, 33, 107, 33, 33, 33, 106, 107]) → {33: 4, 106: 1, 107: 3}
         * IntCount([]) → {}
         *
         */
        public Dictionary<int, int> IntCount(int[] ints)
        {
            Dictionary<int, int> theseWords = new Dictionary<int, int>();
            int counter = 1;

            if (ints != null || ints.Length != 0)
            {

                for (int i = 0; i < ints.Length; i++)
                {
                    if (i == 0)
                    {
                        for (int u = i + 1; u < ints.Length; u++)
                        {
                            if (ints[u] == ints[i])
                            {
                                counter++;
                            }
                        }
                        int theKey = ints[i];
                        theseWords[theKey] = counter;
                        counter = 1;
                    }
                    if (i > 0 && i < ints.Length - 1)
                    {
                        for (int k = 0; k < i; k++)
                        {
                            if (ints[k] == ints[i])
                            {
                                counter++;
                            }
                        }
                        for (int j = i + 1; j < ints.Length; j++)
                        {
                            if (ints[j] == ints[i])
                            {
                                counter++;
                            }
                        }
                        int theKey = ints[i];
                        theseWords[theKey] = counter;
                        counter = 1;
                    }
                    if (i == ints.Length - 1)
                    {
                        for (int w = 0; w < ints.Length - 1; w++)
                        {
                            if (ints[w] == ints[i])
                            {
                                counter++;
                            }
                        }
                        int theKey = ints[i];
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
