using System;

namespace Variables_And_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {



            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */

            int numberOfExercises = 26;
            Console.WriteLine(numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */
            double half = 0.5;
            Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */
            string name = "TechElevator";
            Console.WriteLine(name);

            /*
            4. Create a variable called seasonsOfFirefly and set it to 1.
            */
            int seasonsOfFirefly = 1;
            Console.WriteLine(seasonsOfFirefly);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */
            string myFavoriteLanguage = "C#";
            Console.WriteLine(myFavoriteLanguage);

            /*
            6. Create a variable called pi and set it to 3.1416.
            */
            double pi = 3.1416;
            Console.WriteLine(pi);

            /*
            7. Create and set a variable that holds your name.
            */
            string me = "Sammy";
            Console.WriteLine(me);
            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */
            int mouseButtons = 6;
            Console.WriteLine(mouseButtons);
            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */
            float phoneBattery = 58;
            Console.WriteLine(phoneBattery);
            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */
            int diff = 121 - 27;
            Console.WriteLine(diff);
            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
            float sum = 12.3f + 32.1f;
            Console.WriteLine(sum);
            /*
            12. Create a string that holds your full name.
            */
            string fullName = "Samuel Elliott";
            Console.WriteLine(fullName);
            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string greeting = "Hello " + fullName;
            Console.WriteLine(greeting);
            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */
            string fullGreeting = greeting + " Esquire!";
            Console.WriteLine(fullName);
            /*
            15. Now do the same as exercise 14, but use the += operator.
            */
            string fullerGreeting = greeting += " Esquire!";
            Console.WriteLine(fullerGreeting);
            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */
            string filmName = "Saw"; 
            filmName += " 2";
            Console.WriteLine(filmName);
            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */
            filmName += "0";
            Console.WriteLine(filmName);
            /*
            18. What is 4.4 divided by 2.2?
            */
            double division = 4.4 / 2.2;
            Console.WriteLine(division);
            /*
            19. What is 5.4 divided by 2?
            */
            double bruh = 5.4 / 2;
            Console.WriteLine(bruh);
            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */
            double thisDude = 5 / 2;
            Console.WriteLine(thisDude);
            /*
            21. What is 5.0 divided by 2?
            */
            double gotEm = 5.0 / 2;
            Console.WriteLine(gotEm);
            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */
            float bankBalance = 1234.56f;
            Console.WriteLine(bankBalance);
            /*
            23. If I divide 5 by 2, what's my remainder?
            */
            double rem = 5 % 2;
            Console.WriteLine(rem);
            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together.
                What is the result?
            */
            int num1 = 3;
            int num2 = 1000000000;
            int prod = num1 * num2;
            Console.WriteLine(prod);
            /*
            25. Create a variable that holds a boolean called isDoneWithExercises and
            set it to false.
            */
            bool isDoneWithExercises = false;
            /*
            26. Now set isDoneWithExercise to true.
            */
            isDoneWithExercises = true;

            Console.ReadLine();
        }
    }
}
