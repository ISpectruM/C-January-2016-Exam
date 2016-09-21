using System;

namespace _03.IlluminatiLock
{
    class IlluminatiLock
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            string dots = new string('.', num);

            // top part of the eye
            Console.WriteLine("{0}{1}{2}", dots, new string('#',num),dots);

            for (int rows = 1; rows < num-1/2; rows+=2)
            {
                // top left iris
                for (int leftCol = 0; leftCol < num-rows-1; leftCol++)
                {
                    Console.Write(".");
                }
                Console.Write("##");

                for (int leftCol = 0; leftCol < rows-1; leftCol++)
                {
                    Console.Write(".");
                }

                // the apple of the eye
                Console.Write("#{0}#",new string('.',num-2));

                // top right iris
                for (int rightCol = 0; rightCol < rows-1; rightCol++)
                {
                    Console.Write(".");
                }
                Console.Write("##");

                for (int rightCol = 0; rightCol < num - rows - 1; rightCol++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

            // bottom part of the eye
            for (int bottomRows = 1; bottomRows < num - 1 / 2; bottomRows += 2)
            {
                for (int leftCol = 1; leftCol <= bottomRows; leftCol++)
                {
                    Console.Write(".");
                }
                Console.Write("##");

                for (int leftCol = 0; leftCol < num-bottomRows-2; leftCol++)
                {
                    Console.Write(".");
                }

                // bottom apple of the eye
                Console.Write("#{0}#", new string('.', num - 2));

                for (int rightCol = 0; rightCol < num - bottomRows - 2; rightCol++)
                {
                    Console.Write(".");
                }
                Console.Write("##");

                for (int rightCol = 0; rightCol < bottomRows; rightCol++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.WriteLine("{0}{1}{2}", dots, new string('#', num), dots);
        }
    }
}
