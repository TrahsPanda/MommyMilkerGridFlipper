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
            /* Example output: 
                  117   63  203  253   22   50   57  206  184  224
                   10   66   39    6   23   74   49  118   40   10
                   39  133  164   41  191  170  216  245   72  217
                  117  189  220   22   79  203   21   73  250   29
                  189   15  103  198  100    2  219  173  180   59
                   89   80  186  179   46  239  154  161   62  107
                   89   68  133  222  106   77  102   16  182   75
                   53  231  123   10   77   23   29  221  197  189
                  206   43   65   13  128   36    2   41  232   95
                   48  115   11  142  195  120  138  137   92   22

                FLIP
                THAT
                GRID

                   48  115   11  142  195  120  138  137   92   22
                  206   43   65   13  128   36    2   41  232   95
                   53  231  123   10   77   23   29  221  197  189
                   89   68  133  222  106   77  102   16  182   75
                   89   80  186  179   46  239  154  161   62  107
                  189   15  103  198  100    2  219  173  180   59
                  117  189  220   22   79  203   21   73  250   29
                   39  133  164   41  191  170  216  245   72  217
                   10   66   39    6   23   74   49  118   40   10
                  117   63  203  253   22   50   57  206  184  224
            */

        }
    }
}
