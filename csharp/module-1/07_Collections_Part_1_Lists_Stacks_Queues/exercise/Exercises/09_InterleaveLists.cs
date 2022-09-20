using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given two lists of Integers, interleave them beginning with the first element in the first list followed
        by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
        Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
        list to the new list before returning it.
        DIFFICULTY: HARD
        InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
        */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            int remainder = 0;
            int checker = 0;

            if (listOne.Count == listTwo.Count)
            {
                remainder = 0;
                checker = 0;
            }

            if (listOne.Count > listTwo.Count)
            {
                remainder = listOne.Count - listTwo.Count;
                checker = 1;
            }
            if (listTwo.Count > listOne.Count)
            {
                remainder = listTwo.Count - listOne.Count;
                checker = 2;
            }

            List<int> newList = new List<int>();

            if (checker == 0)
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    newList.Add(listOne[i]);
                    newList.Add(listTwo[i]);
                }
            }

            if (checker == 1)
            {
                for (int i = 0; i < listTwo.Count; i++)
                {
                    newList.Add(listOne[i]);
                    newList.Add(listTwo[i]);
                }

                for (int i = listTwo.Count; i < listOne.Count; i++)
                {
                    newList.Add(listOne[i]);
                }
            }

            if (checker == 2)
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                        newList.Add(listOne[i]);
                        newList.Add(listTwo[i]);
                }

                for (int i = listOne.Count; i < listTwo.Count; i++)
                {
                    newList.Add(listTwo[i]);
                }
            }
            return newList;


        }
    }
}
