using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace Program
{
    //-----------------------------------------------------------------------//

    class studentCollection
    {
        List<Student> _students = new List<Student>();
        public string CollectionName { get; set; }
        public event StudentListHandler StudentCountChanged;
        public event StudentListHandler StudentReferenceChanged;

        public bool Remove(int j)
        {
            if (j < 0 || j >= _students.Count)
            {
                return false;
            }
            Student DeletedElem = _students[j];
            _students.RemoveAt(j);
            StudentCountChanged(this, new StudentListHandlerEventArgs(CollectionName, "Remove", DeletedElem));
            return true;
        }
        public Student this[int index]
        {
            get { return _students[index]; }
            set
            {
                _students[index] = value;
                if (StudentReferenceChanged != null) StudentReferenceChanged(this, new StudentListHandlerEventArgs(CollectionName, "Append", value));
            }
        }
        public void AddDefaults(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Student student = new Student();
                _students.Add(student);
                if (StudentReferenceChanged != null) StudentCountChanged(this, new StudentListHandlerEventArgs(CollectionName, "Append", student));
            }
        }

        public void AddStudent(params Student[] studentsp)
        {
            foreach (Student obj in studentsp)
            {
                _students.Add(obj);
                if (StudentCountChanged != null) { StudentCountChanged(this, new StudentListHandlerEventArgs(CollectionName, "Append", obj)); };
            }
        }
        public override string ToString()
        {
            StringBuilder data = new StringBuilder();

            foreach (Student obj in _students)
            {
                data.Append(obj.ToString());
            }
            string allpoles = $"{data.ToString()}";
            return allpoles;
        }
        public virtual string ToShortString()
        {
            StringBuilder data = new StringBuilder();

            foreach (Student obj in _students)
            {
                data.Append(obj.ToShortString());
            }
            string allpoles = $"{data}";
            return allpoles;
        }
        public List<Student> Sort()
        {
            List<Student> copy = _students.ToList();
            copy.Sort();
            return copy;
        }
        //public List<Student> AverageMarkGroup(double value)
        //{

        //}
        public double MaxAverageMark
        {
            get
            {
                if (_students.Count == 0)
                {
                    return 0;
                }
                return _students.Max(x => x.AverageExam);
            }
        }

        public IEnumerable<Student> Masters
        {
            get
            {
                return _students.Where(x => x.Form == Education.Master);
            }
        }

    }
}