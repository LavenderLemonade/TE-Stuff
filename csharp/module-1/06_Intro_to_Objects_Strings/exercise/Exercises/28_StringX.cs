namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            char[] holderBoi = new char[str.Length];

            for (int i =0; i < str.Length; i++)
            {
                holderBoi[i] = str[i];
            }

            for (int i = 1; i < str.Length-2; i++)
            {
                if (str[i] == 'x')
                {
                    char redField = '_';
                    holderBoi[i] = redField;
                    
                }
            }

            string midArray = string.Join('_', holderBoi);
            string[] finArray = midArray.Split('_');
            string finalAnswer = string.Join("", finArray);
            return finalAnswer;
        }
    }
}
