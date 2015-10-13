using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarbageCollectionAssignment
{
    class Garbage
    {
        int[] a = new int[100];
    }
    class MoreGarbage : Garbage
    {
        int[] c = new int[10000];
    }

    class Program
    {
        static void Main(string[] args)
        {
            Program.createGarbage(1000);
            Console.WriteLine("Memory used before collection:" + GC.GetTotalMemory(false));
            // Collect garbage
            GC.Collect();
            Console.WriteLine("Memory used after full collection:" + GC.GetTotalMemory(false));
            Console.Read();
        }

        static void createGarbage(int limit)
        {
            Garbage gb;
            for (int i = 0; i < limit; i++)
            {
                gb = new Garbage();
                //gb = new MoreGarbage ();
            }
        }
    }
}
