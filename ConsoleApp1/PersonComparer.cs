using System;
using System.Collections.Generic;
namespace Program
{
    class PersonComparer : IComparer<Person>
    {
        public int Compare(Person? p1, Person? p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentException("Некорректное значение параметра");
            return p1.Date.Year - p2.Date.Year;
        }
    }
}