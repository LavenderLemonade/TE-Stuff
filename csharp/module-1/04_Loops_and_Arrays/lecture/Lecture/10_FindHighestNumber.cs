namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        10. What code do we need to write so that we can find the highest
             number in the array randomNumbers?
             TOPIC: Looping Through Arrays
        */
        public int FindTheHighestNumber(int[] randomNumbers)
        {
            int num1 = 0;
            int num2 = 0;

            for (int i = 0; i < randomNumbers.Length-1; i++)
            {
                num1 = randomNumbers[i];
                if (num1 > num2 && i != randomNumbers.Length-1)
                {
                    num2 = num1;
                    continue;
                }
                if (num2 > num1 && i != randomNumbers.Length-1)
                {
                    num1 = num2;
                    continue;
                }
                if (num1 > num2 && i == randomNumbers.Length-1)
                {
                    break;
                }
            }
            return num1;
        }
    }
}
