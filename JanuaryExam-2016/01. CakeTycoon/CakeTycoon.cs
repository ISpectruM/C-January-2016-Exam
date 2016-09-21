using System;

namespace _01.CakeTycoon
{
    class CakeTycoon
    {
        static void Main()
        {
            ulong cakesWanted = ulong.Parse(Console.ReadLine());
            decimal flourPerCake = decimal.Parse(Console.ReadLine());
            uint flourAvailable = uint.Parse(Console.ReadLine());
            uint truffelsAvailable = uint.Parse(Console.ReadLine());
            uint truffelPrice =uint.Parse(Console.ReadLine());

            var cakesProduced = Math.Floor(flourAvailable/flourPerCake);
            ulong trufflesPrice = (ulong)truffelsAvailable * truffelPrice;

            if (cakesWanted <= cakesProduced)
            {
                double cakePrice = ((double)trufflesPrice / cakesWanted) * 1.25d;
                Console.WriteLine("All products available, price of a cake: {0:F2}", cakePrice);
            }
            else
            {
                double flourNeeded = (cakesWanted * (double)flourPerCake) - flourAvailable;
                Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", cakesProduced,flourNeeded);
            }

        }
    }
}
