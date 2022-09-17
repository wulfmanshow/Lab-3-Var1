namespace Program
{
    //-----------------------------------------------------------------------//

    public class Test
    {
        public string Name { get; set; }
        public bool _info { get; set; }

        //
        public Test(string Name, bool info)
        {
            this.Name = Name;
            _info = info;
        }

        //
        public Test() : this("Math", false)
        {
        }

        //
        public override string ToString()
        {
            string allpoles = $"Name: {Name},Passed {_info}";
            return allpoles;
        }
    }
}