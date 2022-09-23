namespace Exercises.Classes
{
    public class FruitTree
    {

        public string TypeOfFruit { get; private set; }

        public int PiecesOfFruitLeft { get; private set; }

        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            this.PiecesOfFruitLeft = startingPiecesOfFruit;
            this.TypeOfFruit = typeOfFruit;
        }

        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if (PiecesOfFruitLeft >= numberOfPiecesToRemove)
            {
                PiecesOfFruitLeft -= numberOfPiecesToRemove;
                return true;
            }
            if (PiecesOfFruitLeft > 0)
            {
                return true;
            }
            return false;
        }











    }
}
