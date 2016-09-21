using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MasterHerbalist
{
    class MasterHerbalist
    {
        static void Main()
        {
            double expenses = double.Parse(Console.ReadLine());
            double seasonTotal = 0.0;
            int daysTotal = 0;
            string oneDay="";
            double averageEarnings = 0.0;

            while (true)
            {
                int hourCounter = 0;
                oneDay = Console.ReadLine();
                if (oneDay == "Season Over")
                {
                    break;
                }
                string[] parameters = oneDay.Split();
                int hours = int.Parse(parameters[0]);
                string path = parameters[1].ToLower();
                double price = double.Parse(parameters[2]);

                for (int i = 0; i < hours; i++)
                {
                    char location = path[hourCounter];
                    if (location=='h')
                    {
                        seasonTotal += price;
                    }

                    hourCounter++;
                    if (hourCounter >= path.Length)
                    {
                        hourCounter = 0;
                    }
                }
                daysTotal++;
            }
            averageEarnings = seasonTotal / daysTotal;
            if (averageEarnings>=expenses)
            {
                Console.WriteLine("Times are good. Extra money per day: {0:f2}.", (averageEarnings-expenses));
            }

            else
            {
                Console.WriteLine("We are in the red. Money needed: {0}.",(expenses-averageEarnings)*daysTotal);
            }
        }
    }
}
