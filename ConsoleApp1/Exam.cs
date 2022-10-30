using System;
namespace Program
{
    //-----------------------------------------------------------------------//
    public class Exam
    {
        public string Yrok { get; set; }
        public int Mark { get; set; }
        public DateTime Dateisp { get; set; }

        //
        public Exam(string yrokp, int markp, DateTime Dateispp)
        {
            Yrok = yrokp;
            Mark = markp;
            Dateisp = Dateispp;
        }

        public Exam() : this("", 3, default(DateTime)) { }
        
        //
        public string YrokP
        {
            get { return Yrok; }
            set { Yrok = value; }
        }

        //
        public int MarkP
        {
            get { return Mark; }
            set { Mark = value; }
        }
        public DateTime DateispP
        {
            get { return Dateisp; }
            set { Dateisp = value; }
        }

        //
        override public string ToString()
        {
            string allpoles = $" Yrok: {Yrok}, Mark: {Mark}, Data Ispita: {Dateisp.ToShortDateString()}";
            return allpoles;
        }

    }
}