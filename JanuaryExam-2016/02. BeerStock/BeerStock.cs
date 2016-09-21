using System;

namespace _02.BeerStock
{
    class BeerStock
    {
        static void Main()
        {

            long reserved = int.Parse(Console.ReadLine());
            bool end = false;
            long beersSum = 0;
            long count = 0;
            string type = "";

            while (end==false)
            {
                String beers = Console.ReadLine().ToLower();
                if (beers == "exam over")
                {
                    end = true;
                }
                else
                {
                    String[] delivery = beers.Split(' ');
                    for (int index = 0; index < 2; index++)
                    {
                        count = int.Parse(delivery[0]);
                        type = delivery[1];
                        if (type=="sixpacks")
                        {
                            count *= 6;
                        }
                        else if (type=="cases")
                        {
                            count *= 24;
                        }
                        else if(type =="beers")
                        {
                            count *= 1;
                        }
                    }
                    beersSum += count;
                }
                
            }
            if (beersSum>=100)
            {
                beersSum = beersSum - (beersSum/100);
            }
            long casesLeft = Math.Abs((beersSum - reserved) / 24);
            long sixpacksLeft = Math.Abs(((beersSum-reserved) % 24) / 6);
            long beersLeft = Math.Abs(((beersSum - reserved) % 24) % 6);

            if (reserved <= beersSum)
            {
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", casesLeft, sixpacksLeft, beersLeft);
            }
            else
            {
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", casesLeft, sixpacksLeft, beersLeft);
            }

        }
    }
}
