using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Program
{
    class StudentComparrer : IComparer<Student>
    {
        public int Compare( Student x, Student y)
        {
            return (int)(x.AvarageExam - y.AvarageExam);
        }

    }
}
