using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class TestCollection
    {
        public List<Person> persColl = new List<Person>();
        public List<string> str = new List<string>();
        public Dictionary<Person, Student> personStud = new Dictionary<Person, Student>();
        public Dictionary<string, Student> stringStud = new Dictionary<string, Student>();
        private Student _stud;

        public TestCollection(int CollSize)
        {
            for (int i = 0; i < CollSize; i++)
            {
                _stud = NewStudent(i);

                persColl.Add(_stud);
                str.Add(_stud.ToShortString());
                personStud.Add(_stud, _stud);
                stringStud.Add(_stud.ToShortString(), _stud);
            }
        }

        public void SearchTimeDefault()
        {
            SearchTime(_stud);
        }


        public void SearchTime(Student student)
        {
            Person person = student;
            int index = 0;
            string shortStud = student.ToShortString();
            int time = Environment.TickCount;
            bool isFounded = false;
            isFounded = persColl.Contains(student);
            time = Environment.TickCount - time;
            Console.WriteLine($"знайдено:{isFounded}, час пошуку елемента _persColl: {time}\n");
            time = Environment.TickCount;
            isFounded = str.Contains(shortStud);
            time = Environment.TickCount - time;
            Console.WriteLine($"знайдено:{isFounded}, час пошуку елемента _str: {time}\n");
            time = Environment.TickCount;
            index = persColl.LastIndexOf(student);
            time = Environment.TickCount - time;
            Console.WriteLine($"Індекс:{index}, час пошуку елемента _persColl: {time}\n");
            time = Environment.TickCount;
            index = str.LastIndexOf(shortStud);
            time = Environment.TickCount - time;
            Console.WriteLine($"Індекс:{index}, час пошуку елемента _str: {time}\n");
            time = Environment.TickCount;
            isFounded = personStud.ContainsKey(person);
            time = Environment.TickCount - time;
            Console.WriteLine($"знайдено:{isFounded}, час пошуку елемента по ключу _personStud: {time}\n");
            time = Environment.TickCount;
            isFounded = stringStud.ContainsKey(shortStud);
            time = Environment.TickCount - time;
            Console.WriteLine($"знайдено:{isFounded}, час пошуку елемента по ключу _stringStud: {time}\n");
            time = Environment.TickCount;
            isFounded = personStud.ContainsValue(student);
            time = Environment.TickCount - time;
            Console.WriteLine($"знайдено:{isFounded}, час пошуку елемента по значенню _personStud: {time}\n");
            time = Environment.TickCount;
            isFounded = stringStud.ContainsValue(student);
            time = Environment.TickCount - time;
            Console.WriteLine($"знайдено:{isFounded}, час пошуку елемента по значенню _stringStud: {time}\n");

        }

        public static Student NewStudent(int param)
        {
            return new Student();
        }
    }
}
