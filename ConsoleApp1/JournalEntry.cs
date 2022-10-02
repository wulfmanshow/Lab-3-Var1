using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class JournalEntry
    {
        public string CollectionName { get; set; }
        public string ChangeType { get; set; }
        public string StudentData { get; set; }
        public JournalEntry(string collname, string changetype,string StudData)
        {
            CollectionName = collname;
            ChangeType = changetype;
            StudentData = StudData;
        }
        public override string ToString()
        {
            return $"CollectionName - {CollectionName}, ChangeType - {ChangeType}, Student - {StudentData}";
        }
    }
}
