using System;
namespace Program
{

    interface IDateAndCopy
    {
        Object DeepCopy();
        public DateTime Date { get; set; }
    }
    public enum Education
    {
        Master,
        Bachelor,
        SecondEducation
    }
    class Program
    {

        static void Main(string[] args)
        {
            Exam generatorexam()
            {
                Exam item = new Exam();
                Random r = new Random();
                item.Yrok = "Any";
                item.Mark = r.Next(2, 12);
                item.Dateisp = new DateTime(r.Next(2021, 2040), r.Next(1, 12), r.Next(1, 28));
                return item;
            }
            Exam[] generatorexams(int lenght)
            {
                Exam[] data = new Exam[lenght];
                for (int i = 0; i < lenght; i++)
                {
                    data[i] = generatorexam();
                }
                return data;
            }
          
   
            Console.WriteLine("\n\n\n\n\n\n");
            Student test1 = new Student();

            studentCollection s3 = new studentCollection();
            Exam testExam1 = new Exam();
            test1.AddExams(testExam1);
            s3.AddStudent(test1);
            Console.WriteLine(s3.ToShortString());
            Console.WriteLine(s3.ToString());
            Console.WriteLine("\n\n\n\n\n\n");
            Person person = new Person();
            person.YearBorn = 2006;
            DateTime dataexam = new DateTime(2023, 5, 15);
            Exam[] allexam = new Exam[3] { new Exam("Math", 1, dataexam), new Exam("English", 3, dataexam), new Exam() };
            Test[] alltest = new Test[3] { new Test("Math",true ), new Test("abc",false ), new Test("sdh", false) };
            Student[] allStudents = new Student[4] { new Student(), new Student("max","poletaev", DateTime.Now,Education.Bachelor,3), new Student("Avram", "Lincoln", DateTime.Now, Education.Bachelor, 3), new Student("John", "seena", DateTime.Now, Education.Bachelor, 3) };
            studentCollection bx = new studentCollection();
            bx.AddStudent(allStudents);
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine(bx.ToShortString());
            Console.WriteLine("\n\n");
            foreach (Student i in bx.Sort())
            {
                Console.WriteLine(i.ToShortString());
            }
            

            Console.WriteLine("\n\n\n\n\n\n");
            //Console.WriteLine(person.DataBorn);
            //Console.WriteLine(person.ToString());
            //Console.WriteLine(person.ToShortString());
            Student s = new Student();
            Console.WriteLine(s.ToShortString());
            Console.WriteLine(s[Education.Master] + ", " + s[Education.Bachelor] + ", " + s[Education.SecondEducation]);
            s.Date = person.Date;
            s.Form = Education.Bachelor;
            s.IdGroup = 10893;
            s.AddExams(allexam);
            s.AddTests(alltest);
            Console.WriteLine("\n\n\n");
            Console.WriteLine(s.ToString());
            Student s1 = (Student)s.DeepCopy();
            Console.WriteLine("\n\n\n");
            Student.PrintValuesByMark(s.Exams, 3);
            Console.WriteLine("\n\n\n");
            foreach (string examname in s)
            {
                Console.WriteLine(examname);
            }
            foreach (string examname in s.Passed)
            {
                Console.WriteLine(examname);
            }
            Console.WriteLine("\n\n\n");
            allexam[0].Mark = 10;
            allexam[1].Yrok = "Botanic";
            s.AddExams(allexam);
            Console.WriteLine(s.ToShortString());
            int n = int.Parse(Console.ReadLine()), m = int.Parse(Console.ReadLine());
            Exam[] d1 = new Exam[n * m];
            Exam[,] d2 = new Exam[n, m];
            Exam[][] d3 = new Exam[n][];
            d1 = generatorexams(n * m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    d2[i, j] = generatorexam();
                }
            }
            for (int i = 0; i < n; i++)
            {

                d3[i] = new Exam[m];
                d3[i] = generatorexams(m);
            }
            int len = n * m;
            int time = Environment.TickCount;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    d3[i][j].Mark = 10;
                }
            }

            Console.WriteLine(Environment.TickCount - time);
            time = Environment.TickCount;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    d2[i, j].Mark = 10;
                }
            }
            Console.WriteLine(Environment.TickCount - time);
            time = Environment.TickCount;
            for (int i = 0; i < len; i++)
            {
                d1[i].Mark = 10;
            }
            Console.WriteLine(Environment.TickCount - time);
            Person p1 = new Person("Mikola", "Masian", default(DateTime));
            Person p2 = new Person("Mikola", "Masian", default(DateTime));
            Console.WriteLine(p2.Equals(p1));
            Console.WriteLine(p1 == p2);
            Console.WriteLine("\n\n\n");
            Console.WriteLine(new Student());
            TestCollection testcoll = new TestCollection(1000);
            Console.WriteLine("Створенно!");
            testcoll.SearchTime(new Student());
            Console.WriteLine("\n\n\n");
            testcoll.SearchTimeDefault();
            studentCollection studentcoll1 = new studentCollection();
            studentCollection studentcoll2 = new studentCollection();
            Journal journal1 = new Journal();
            Journal journal2 = new Journal();
            studentcoll1.StudentCountChanged += journal1.StudentCountChanged;
            studentcoll1.StudentReferenceChanged += journal1.StudentReferenceChanged;
            studentcoll1.StudentCountChanged += journal2.StudentCountChanged;
            studentcoll1.StudentReferenceChanged += journal2.StudentReferenceChanged;
            studentcoll2.StudentCountChanged += journal2.StudentCountChanged;
            studentcoll2.StudentReferenceChanged += journal2.StudentReferenceChanged;
            studentcoll1.AddDefaults(10);
            Console.WriteLine(studentcoll1.ToString());
            studentcoll2.AddDefaults(11);
            Console.WriteLine(studentcoll2.ToString());
            studentcoll1.Remove(4);
            Console.WriteLine(studentcoll1.ToString());
            studentcoll2.Remove(5);
            Console.WriteLine(studentcoll2.ToString());
            studentcoll1[2] = new Student();
            Console.WriteLine(studentcoll1.ToString());
            studentcoll2[5] = new Student();
            Console.WriteLine(studentcoll2.ToString());
            Console.WriteLine($"journal 1 -{journal1.ToString()}\n journal 2 -{journal2.ToString()}");

            foreach(Student student in studentcoll1.Masters)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\n\n\n\n");
            foreach (Student student in studentcoll1.AverageMarkGroup(3))
            {
                Console.WriteLine($"{student.ToString()}\n\n");
            }
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine(studentcoll1.MaxAverageMark);
        }
    }
}