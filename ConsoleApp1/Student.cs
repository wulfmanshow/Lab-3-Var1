using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
namespace Program
{
    //-----------------------------------------------------------------------//
    public class Student : Person, IDateAndCopy, IEnumerable
    {

        private Education _educationForm;
        private int _groupId;
        private List<Test> _TestList = new List<Test>();
        protected List<Exam> ExamList = new List<Exam>();


        //
        public Student(string name, string surname, DateTime date, Education form, int idgp) : base(name, surname, date)
        {
            _educationForm = form;
            _groupId = idgp;
            ExamList = new List<Exam>();
        }

        //
        public Student(string name, string surname, DateTime date, Education form, int idgp, List<Exam> Examlist) : base(name, surname, date)
        {
            _educationForm = form;
            _groupId = idgp;
            ExamList = Examlist;
        }

        //
        public Student() : this(RndGenerator.GenerateName(5), RndGenerator.GenerateName(8), RndGenerator.GenerateBornDate(), new Education(), 101,ExamGenerator.CreateExamList())
        {
            Array values = Enum.GetValues(typeof(Education));
            Random random = new Random();
            _educationForm = (Education)values.GetValue(random.Next(values.Length));
        }


        //
        public Person pers
        {
            get => new Person(Name, SurName, Date);
            set { this.Name = value.Name; this.SurName = value.SurName; this.Date = value.Date; }
        }
        public override object DeepCopy() => new Student(Name, SurName, Date, _educationForm, _groupId, ExamList);

        //
        public double AverageExam
        {
            get
            {
                int count = 0;
                int sum = 0;
                foreach (Exam obj in ExamList)
                {
                    count++;
                    sum += obj.Mark;
                }
                double Avarage = (double)sum / count;
                return Avarage;
            }

        }

        //
        public List<Exam> Exams
        {
            get { return ExamList; }
            set { ExamList = value; }
        }

        //
        public Education Form
        {
            get { return _educationForm; }
            set { _educationForm = value; }
        }

        //
        public int IdGroup
        {
            get { return _groupId; }
            set
            {
                if (_groupId <= 100 && _groupId >= 699)
                {
                    throw new Exception("Помилка:номер группи має бути вище 100 і менше 699!");
                }
                _groupId = value;
            }
        }

        
        //
        public bool this[Education index]
        {
            get { return index == _educationForm; }

        }


        //
        public void AddExam(Exam exam)
        {
            ExamList.Add(exam);
        }

        //
        public void AddTest(Test test)
        {
            _TestList.Add(test);
        }

        //
        public void AddExams(params Exam[] exams)
        {

            foreach (Exam obj in exams)
            {
                ExamList.Add(obj);
            }
        }

        //
        public void AddTests(params Test[] tests)
        {

            foreach (Test obj in tests)
            {
                _TestList.Add(obj);
            }
        }

        //
        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            foreach (Exam obj in ExamList)
            {
                data.Append(obj.ToString());
            }
            return $" {base.ToString()}, School Form: {Form}, ID: {IdGroup}, All Exams: {data.ToString()}, AverageMark:{AverageExam}\n";
        }

        //
        public override string ToShortString()
        {
            return $" {base.ToShortString()}, School Form: {Form}, ID: {IdGroup}, Year Mark: {AverageExam}\n";
        }

        //
        public static void PrintValuesByMark(IEnumerable myList, double MarkR)
        {
            foreach (Exam obj in myList)
            {
                if (obj.Mark >= MarkR)
                {
                    Console.Write("   {0}", obj);
                }
            }

            Console.WriteLine();
        }


        //
        public IEnumerable Passed
        {
            get
            {
                foreach (Exam ex in ExamList)
                {
                    if (ex.Mark >= 2)
                    {
                        yield return ex.Yrok;
                    }
                }
                foreach (Test t in _TestList)
                {
                    if (t._info == true)
                    {
                        yield return t.Name;
                    }
                }
            }
        }

        //
        public IEnumerator GetEnumerator()
        {
            //return new StudentEnumerator(_ExamList);
            foreach(Exam ex in ExamList )
            {
                foreach(Test t in _TestList)
                {
                    if(t.Name == ex.Yrok)
                    {
                        yield return t.Name;
                    }
                } 
            }
        }

    }
}