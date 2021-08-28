using System;
using System.Linq;
using System.Reflection;

namespace Reflection
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var assembly = System.Reflection.Assembly.GetAssembly(typeof(Program));
            Console.WriteLine(assembly);
            Console.WriteLine(assembly.EntryPoint);
           
            //---------------------------

            var assembly2 = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                var typeInfo = type.GetTypeInfo();
                Console.WriteLine("Type " + type.FullName + " has " + typeInfo.DeclaredProperties.Count().ToString() + " properties");
            }
        }
    }
}
