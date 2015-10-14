using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortPersonByAge
{
    class Person : IComparable
    {
        public string FirstName { get; set; }
        public string LastName {get;set;}
        public int Age {get;set;}

        public Person()
        {
        }
        public int CompareTo(object obj)
        {
            if (obj is Person)
            {
                return this.Age.CompareTo((obj as Person).Age);
            }
            throw new NotImplementedException();
        }
    }
}
