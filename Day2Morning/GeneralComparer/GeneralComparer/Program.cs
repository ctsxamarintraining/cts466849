using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] pArray = new Person[4];

            pArray[0] = new Person("SRINIVAS", 24);
            pArray[1] = new Person("SUNIL", 26);
            pArray[2] = new Person("SOWMYA", 25);
            pArray[3] = new Person("RAMYA", 20);


            Array.Sort(pArray, Person.SortByName);

            for (int i = 0; i < pArray.Length; i++)
            {

                Console.WriteLine(pArray[i].name);
            }
            Console.Read();
        }
    }
}
