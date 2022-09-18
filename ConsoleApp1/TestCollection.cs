using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class TestCollection
    {
        public List<Person> _persColl = new List<Person>();
        public List<string> _str = new List<string>();
        public Dictionary<Person, Student> _personStud = new Dictionary<Person, Student>();
        public Dictionary<string, Student> _stringStud = new Dictionary<string, Student>();
        private Student stud;
        public TestCollection(int CollSize)
        {
         for(int i = 0; i < CollSize; i++)
            {
                 stud = NewStudent(i);

                _persColl.Add(stud);
                _str.Add(stud.ToShortString());
                _personStud.Add(stud, stud);
                _stringStud.Add(stud.ToShortString(), stud);
            }   
        }

        public void searchTime()
        {
            Person person = stud;
            string shortStud = stud.ToShortString();
            int time = Environment.TickCount;
            bool isFounded = false;
           isFounded = _persColl.Contains(stud);
            time = Environment.TickCount- time;
            Console.WriteLine($"знайдено:{isFounded}, час пошуку елемента _persColl: {time}\n");
             time = Environment.TickCount;
            isFounded = _str.Contains(shortStud);
            time = Environment.TickCount - time;
            Console.WriteLine($"знайдено:{isFounded}, час пошуку елемента _str: {time}\n");
            time = Environment.TickCount;
            isFounded = _personStud.ContainsKey(person);
            time = Environment.TickCount - time;
            Console.WriteLine($"знайдено:{isFounded}, час пошуку елемента по ключу _personStud: {time}\n");
            time = Environment.TickCount;
            isFounded = _stringStud.ContainsKey(shortStud);
            time = Environment.TickCount - time;
            Console.WriteLine($"знайдено:{isFounded}, час пошуку елемента по ключу _stringStud: {time}\n");
            time = Environment.TickCount;
            isFounded = _personStud.ContainsValue(stud);
            time = Environment.TickCount - time;
            Console.WriteLine($"знайдено:{isFounded}, час пошуку елемента по значенню _personStud: {time}\n");
            time = Environment.TickCount;
            isFounded =_stringStud.ContainsValue(stud);
            time = Environment.TickCount - time;
            Console.WriteLine($"знайдено:{isFounded}, час пошуку елемента по значенню _stringStud: {time}\n");

        }

         public static  Student NewStudent(int param)
        {
            return new Student();
        }
    }
}
