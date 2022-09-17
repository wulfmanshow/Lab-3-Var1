using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace Program
{
    //-----------------------------------------------------------------------//
    class studentCollection
    {
        List<Student> _students = new List<Student>();
        public double MaxAvarage { get; set; }
        public void AddDefaults(int count)
        {
            while (count > 0)
            {
                _students.Add(new Student());
                count--;
            }
        }
        public void AddStudent(params Student[] studentsp)
        {
            foreach (Student obj in studentsp)
            {
               _students.Add(obj);
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

    }
}