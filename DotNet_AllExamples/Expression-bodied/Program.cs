using System;

namespace Expression_bodied
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("HE", "Dejesus");
            Console.WriteLine(p);
            p.DisplayName();
        }

    }
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            fname = firstName;
            lname = lastName;
        }

        private string fname;
        private string lname;

        public override string ToString() => $"{fname} {lname}".Trim();
        public void DisplayName() => Console.WriteLine(ToString());
    }

}
