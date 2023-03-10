namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string and an int n, return a string made of the first and last n chars from the string. The
        string length will be at least n.
        NTwice("Hello", 2) → "Helo"
        NTwice("Chocolate", 3) → "Choate"
        NTwice("Chocolate", 1) → "Ce"
        */
        public string NTwice(string str, int n)
        {
            string blue = str.Substring(0, n);
            string yellow = str.Substring(((str.Length) - (n)), n);
            string green = blue + yellow;
            return green;
        }
    }
}
