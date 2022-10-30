using Program;
using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public static class ExamGenerator
    {
        private static Random rnd = new Random(DateTime.Now.Millisecond);
        public static Exam CreateExam()
        {
            return new Exam(GenerateSubject(),GenerateExamMark(),GenerateExamDate());
        }
        public static List<Exam> CreateExamList()
        {
            int i = 0;
            List<Exam> exams = new List<Exam>();
            while(i<= rnd.Next(1, 4+1))
            {
                exams.Add(CreateExam());
                i++;
            }
            return exams;
        }
        public static DateTime GenerateExamDate()
        {
            return DateTime.Now.AddDays(rnd.Next(1, 365+1));
        }
        public static int GenerateExamMark()
        {
            return rnd.Next(1, 5+1);
        }
        public static string GenerateSubject()
        {
            string[] subjects = {"Math","Biology","Physic","English","History" };
            return subjects[rnd.Next(0,subjects.Length)];

        }
    }
}
