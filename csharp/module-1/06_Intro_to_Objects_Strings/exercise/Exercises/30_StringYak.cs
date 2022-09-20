namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed.
        The "yak" strings will not overlap.
        StringYak("yakpak") → "pak"
        StringYak("pakyak") → "pak"
        StringYak("yak123ya") → "123ya"
        */
        public string StringYak(string str)
        {
            char[] theHolder = new char[str.Length];

            for (int z = 0; z < str.Length; z++)
            {
                theHolder[z] = str[z];
            }



            for (int i = 0; i < str.Length-2; i++)
            {
                if (str[i] == 'y' && str[i + 1] == 'a' && str[i + 2] == 'k')
                {
                    theHolder[i] = '0';
                    theHolder[i + 1] = '0';
                    theHolder[i + 2] = '0';

                }
            }


            string midArray = string.Join("", theHolder);
            string[] finArray = midArray.Split('0');
            string finalAnswer = string.Join("", finArray);

            return finalAnswer;
        }
    }
}
