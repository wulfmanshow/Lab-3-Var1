using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Journal
    {
        private List<JournalEntry> JournalList= new List<JournalEntry>();
        public void StudentCountChanged(object source, StudentListHandlerEventArgs args)
        {
            JournalList.Add(new JournalEntry(args.CollectionName, args.ChangeType, args.ObjectReferense.ToShortString()));
        }
        public void StudentReferenceChanged(object source, StudentListHandlerEventArgs args)
        {
            JournalList.Add(new JournalEntry(args.CollectionName, args.ChangeType, args.ObjectReferense.ToShortString()));
        }
        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            foreach(JournalEntry obj in JournalList)
            {
                data.Append(obj.ToString());
            }
            return data.ToString();
        }
    }
}
