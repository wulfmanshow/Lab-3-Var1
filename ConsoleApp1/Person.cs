using System;
using System.Collections.Generic;
namespace Program
{
    //-----------------------------------------------------------------------//

    //public class TestColections
    //{

    //    public List<Test> collection = new List<Test>();
    //    public List<string> str = new List<string>();
    //    public List<Person> Date = new List<Person>();
    //    public List<Exam> listex = new List<Exam>();
    //}
    //-----------------------------------------------------------------------//
    class Person : IDateAndCopy, IComparable
    {
        private string name;
        private string surname;
        public DateTime Date { get; set; }
        //
       
        public Person(string namep, string surnamep, DateTime date)
        {
            name = namep;
            surname = surnamep;
            Date = date;
        }
        private static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }

        //
        public int CompareTo(object? o)
        {
            if (o is Person pers) return name.CompareTo(pers.name);
            else throw new ArgumentException("Некоректное значение параметра");
        }
        public int Compare(Person x, Person y)
        {
            return DateTime.Compare(x.Date, y.Date);
        }

        //
        public Person() : this("Mikola", "Masian", default(DateTime)) { }

        //
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //
        public string SurName
        {
            get { return surname; }
            set { surname = value; }
        }

        //
        public DateTime DataBorn
        {
            get { return Date; }
            set { Date = value; }
        }

        //
        public int YearBorn
        {
            get { return Date.Year; }
            set { Date = Date.AddYears(value - Date.Year); }
        }

        //
        override public string ToString()
        {
            string allpoles = $"Name: {name}, SurName: {surname}, Data Born: {Date.ToShortDateString()}";
            return allpoles;
        }

        //
        virtual public string ToShortString()
        {
            string allpoles = $"{name} {surname}";
            return allpoles;
        }


        //
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.name == p2.name && p1.surname == p2.surname && p1.Date == p2.Date;
        }

        //
        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }

        //
        public virtual object DeepCopy() => new Person(name, surname, Date);

        //
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;// якщо в методі нічого не вписано фолс
            Person m = obj as Person;
            return m.name == this.name && m.surname == this.surname && m.Date == this.Date;
        }

        //
        public override int GetHashCode()
        {
            return Tuple.Create(name, surname, Date).GetHashCode();
        }
    }
}