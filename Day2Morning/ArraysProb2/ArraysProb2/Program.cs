using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysProb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] newArray = new int[4, 2] { { 1, 3 }, { 15, 7 }, { 80, 2 }, { 99, 1 } };
            PrintTheArray(newArray);
            Console.Read();
        }

        static void PrintTheArray(Array theArray)
        {
            foreach (var e in theArray)
                Console.WriteLine(e);
        }

    }
}
