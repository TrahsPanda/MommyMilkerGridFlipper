using System;

namespace MommyMilkerGridFlipper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates new Random
            Random random = new Random();
            // Creates new 100 integer array
            int[] grid = new int[100];
            
            // Generates 100 random numbers from 0 to 256 and assigns them in each index of the grid array
            for (int i = 0; i < 100; i++)
            {
                int randomInt = random.Next(0, 256);
                grid[i] = randomInt;
            }

            // Prints a 10 x 10 grid of the grid array
            int whileControl1 = 0;
            int offset1 = 0;
            int offset2 = 10;
            while (whileControl1 < 10)
            {
                for (int i = offset1; i < offset2; i++)
                {
                    Console.Write("{0,5}", grid[i]);
                }
                offset1 += 10;
                offset2 += 10;
                whileControl1++;
                Console.WriteLine();
            }

            //FLIPS
            Console.WriteLine("\nFLIP");
            //THAT
            Console.WriteLine("THAT");
            //GRID
            Console.WriteLine("GRID\n");

            // Prints the grid array but vertically flipped
            int whileControl2 = 0;
            int offset3 = 90;
            int offset4 = 100;
            while (whileControl2 < 10)
            {
                for (int i = offset3; i < offset4; i++)
                {
                    Console.Write("{0,5}", grid[i]);
                }
                offset3 -= 10;
                offset4 -= 10;
                whileControl2++;
                Console.WriteLine();
            }

        }
    }
}
