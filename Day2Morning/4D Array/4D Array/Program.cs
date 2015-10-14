using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4D_Array
{
    class Program
    {
        static void Main()
        {

            string[, , ,] fourdimension = new string[2, 2, 2, 2];
            fourdimension[0, 0, 0, 0] = "a";
            fourdimension[0, 0, 0, 1] = "b";
            fourdimension[0, 0, 1, 0] = "c";
            fourdimension[0, 0, 1, 1] = "d";
            fourdimension[0, 1, 0, 0] = "e";
            fourdimension[0, 1, 1, 1] = "f";
            fourdimension[0, 1, 1, 0] = "g";
            fourdimension[1, 0, 0, 0] = "h";
            fourdimension[1, 1, 1, 1] = "i";
            fourdimension[1, 0, 1, 0] = "j";
            fourdimension[1, 0, 1, 1] = "k";
            fourdimension[1, 1, 1, 0] = "l";
            fourdimension[0, 1, 1, 1] = "m";
            fourdimension[0, 1, 0, 1] = "n";
            fourdimension[1, 0, 0, 1] = "o";
            fourdimension[1, 1, 0, 0] = "p";



            // Loop over each dimension's length.
            for (int i = 0; i < fourdimension.GetLength(3); i++)
            {
                for (int y = 0; y < fourdimension.GetLength(2); y++)
                {
                    for (int x = 0; x < fourdimension.GetLength(1); x++)
                    {
                        for (int z = 0; z < fourdimension.GetLength(0); z++)
                        {

                            Console.Write(fourdimension[x, y, z, i]);
                            Console.WriteLine('\n');
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    
                }
            }
            Console.Read();
        }
    }
}
