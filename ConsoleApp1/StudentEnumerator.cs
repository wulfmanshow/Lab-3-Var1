using System;
using System.Collections;
using System.Collections.Generic;
namespace Program
{
    //-----------------------------------------------------------------------//


    public class StudentEnumerator : IEnumerator<String>
    {
        private int index = -1;
        private List<Exam> _exams;
        
        public StudentEnumerator(List<Exam> exams)
        {
            _exams = exams;   
        }
        public string Current 
        {
            get { try { return _exams[index].Yrok; } catch (IndexOutOfRangeException) { throw new InvalidOperationException(); } } 
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
           return ++index<_exams.Count;
        }

        public void Reset()
        {
            index = -1;
        }
        
    }
}