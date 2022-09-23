using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given two Dictionaries, Dictionary<string, int>, merge the two into a new Dictionary, Dictionary<string, int> where keys in Dictionary2,
         * and their int values, are added to the int values of matching keys in Dictionary1. Return the new Dictionary.
         *
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *
         * ConsolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         *
         */
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int> mainWarehouse,
                                                            Dictionary<string, int> remoteWarehouse)
        {
<<<<<<< HEAD
           


            foreach (var oneKey in remoteWarehouse.Keys)
            {
                if (mainWarehouse.ContainsKey(oneKey))
                {
                    mainWarehouse[oneKey] = mainWarehouse[oneKey] + remoteWarehouse[oneKey];
                }
                else
                {
                    mainWarehouse.Add(oneKey, remoteWarehouse[oneKey]);
                }

            }
            return mainWarehouse;
=======
            Dictionary<string, int> finalDictionary = new Dictionary<string, int>();
            IEnumerable<string> firstKeys = mainWarehouse.Keys;
            IEnumerable<string> secondKeys = remoteWarehouse.Keys;
            string[] keyRing = new string[firstKeys.Count() + secondKeys.Count()];

            for (int i = 0; i < firstKeys.Count(); i++)
            {
                keyRing[i] = firstKeys.ElementAt(i);
            }

            for (int i = firstKeys.Count(); i < firstKeys.Count() + secondKeys.Count(); i++)
            {
                keyRing[i] = secondKeys.ElementAt(i);
            }

            for (int i = 0; i < keyRing.Length; i++)
            {
                if (i == 0)
                {
                    for (int j = 1; j < keyRing.Length; j++)
                    {
                        if (keyRing[j] == keyRing[i])
                        {
                            finalDictionary[keyRing[j]] = mainWarehouse[keyRing[j]] + remoteWarehouse[keyRing[j]];
                        }
                        else
                        {
                            finalDictionary[keyRing[j]] = mainWarehouse[keyRing[j]];
                        }
                    }
                }
            }





            //foreach (string oneKey in firstKeys)
            //{
            //    foreach (string twoKey in secondKeys)
            //    {
            //        if (oneKey == twoKey)
            //        {
            //            finalDictionary[twoKey] = (mainWarehouse[oneKey] + remoteWarehouse[twoKey]);
            //        }
            //        else
            //        {
            //            finalDictionary[twoKey] = (remoteWarehouse[twoKey]);
            //        }

            //    }

            //    finalDictionary[oneKey] = (mainWarehouse[oneKey]);

            //}
            return finalDictionary;
>>>>>>> 817c54ca1c7120b32c0690ac6b93fdfcfaa7b612
        }
    }
}
