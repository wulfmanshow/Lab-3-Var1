using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public delegate void StudentListHandler(object source, StudentListHandlerEventArgs args);
    public class StudentListHandlerEventArgs : System.EventArgs
    {
         public string CollectionName { get; set; }
        public string ChangeType { get; set; }
        public Student ObjectReferense { get; set; }
        public StudentListHandlerEventArgs(string collname, string changetype, Student objref)
        {
            CollectionName = collname;
            ChangeType = changetype;
            ObjectReferense = objref;
        }
        public override string ToString()
        {            
            return $"CollectionName - {CollectionName}, ChangeType - {ChangeType}, ObjectReferense - {ObjectReferense}"; 
        }
    }
}
