using System;

namespace Record
{
    class Program
    {
        public record Person(string Name);
        public static void Main()
        {
            var me = new Person("😀");
            var me2 = new Person("🤩");

            var sme = me with { Name = "😁" };
            Console.WriteLine(me2 == sme);

        }
    }
}
