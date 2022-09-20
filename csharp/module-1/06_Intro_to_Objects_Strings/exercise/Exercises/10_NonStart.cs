namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given 2 strings, return their concatenation, except omit the first char of each. The strings will
        be at least length 1.
        NonStart("Hello", "There") → "ellohere"
        NonStart("java", "code") → "avaode"
        NonStart("shotl", "java") → "hotlava"
        */
        public string NonStart(string a, string b)
        {
            string blue = a.Substring(1, (a.Length - 1));
            string yellow = b.Substring(1, (b.Length - 1));
            string green = blue + yellow;
            return green;
        }
    }
}
