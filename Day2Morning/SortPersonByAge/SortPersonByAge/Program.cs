using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortPersonByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3];

            Person p1 = new Person();
            p1.FirstName = "Srinivas";
            p1.Age = 1;
            p1.LastName = "C";
            person[0] = p1;

            Person p2 = new Person();
            p2.FirstName = "Sunil";
            p2.Age = 25;
            p2.LastName = "M";
            person[1] = p2;

            Person p3 = new Person();
            p3.FirstName = "Sowmya";
            p3.Age = 24;
            p3.LastName = "R";
            person[2] = p3;

            Array.Sort(person);
            for (int i = 0; i < person.Length; i++)
            {
                if (person[i].Age != null)
                Console.WriteLine(person[i].Age);

            }
            Console.Read();

        }
    }
}
