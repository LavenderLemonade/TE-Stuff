using System;

namespace DiscountCalculator
{
    class Program
    {
        /// <summary>
        /// The main method is the start and end of our program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to the Discount Calculator");


            // Prompt the user for a discount amount
            // The answer needs to be saved as a double
            double thatDiscount = 0;

            do {
                Console.Write("Enter the discount amount (w/out percentage): ");

                string discAmount = Console.ReadLine();
                thatDiscount = double.Parse(discAmount);
                thatDiscount = thatDiscount / 100.0;

                if (thatDiscount > 100)
                {
                    Console.WriteLine("Come on dude, that's too much, relax.");
                   

                }

                Console.WriteLine("You typed: " + thatDiscount);

            }
            while (thatDiscount > 100);





            



            // Prompt the user for a series of prices
            Console.Write("Please provide a series of prices (space separated): ");
            string morePrices = Console.ReadLine();

            Console.WriteLine("You entered: " + morePrices);

            string[] priceArray = morePrices.Split(" ");
            for (int i =0; i < priceArray.Length; i++)
            {
                string value = priceArray[i];
                decimal finPrice = decimal.Parse(value);
                decimal finalPrice = finPrice - (finPrice * (decimal)thatDiscount);
                Console.WriteLine($"Sale price: {finalPrice:C2}");

            }
            
            








        }
    }
}
