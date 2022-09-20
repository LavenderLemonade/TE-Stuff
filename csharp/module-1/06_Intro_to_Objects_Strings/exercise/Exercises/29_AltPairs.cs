namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
        AltPairs("kitten") → "kien"
        AltPairs("Chocolate") → "Chole"
        AltPairs("CodingHorror") → "Congrr"
        */
        public string AltPairs(string str)
        {
            char[] theHolder = new char[str.Length];


            for (int i = 0; i < str.Length; i = i + 4)
            {
                theHolder[i] = str[i];
            }

            for (int j = 1; j < str.Length; j = j + 4)
            {
                theHolder[j] = str[j];
            }

            for (int i = 2; i < str.Length; i = i + 4)
            {
                theHolder[i] = '0';
            }

            for (int j = 3; j < str.Length; j = j + 4)
            {
                theHolder[j] = '0';
            }
            string midArray = string.Join('0', theHolder);
            string[] finArray = midArray.Split('0');
            string finalAnswer = string.Join("", finArray);

            return finalAnswer;


        }
    }
}
