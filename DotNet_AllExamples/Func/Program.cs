using System;

namespace Func
{
    public class User
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public byte Age { get; set; }
    }
    class Program
    {
        delegate int CountIt(int x);
        static void Main(string[] args)
        {
            CountIt expressionLambdaDel = (int x) => x + 5;  //here delegate is used like a function.
            Console.WriteLine(expressionLambdaDel(5));

            Func<int, int, int> sumFunc = (x, y) => x + 1 + y + 1;


            //First Way
            Action<User> action = (x) =>
            {
                x.Age = 20;
                x.Name = "Mostafa";
                x.Family = "Jafari";
            };
            GetUser(action);
            //second way
            GetUser(x => { x.Name = "Reza"; x.Family = "John"; x.Age = 20; });

            Print((x, y) => x + y);
            Print(sumFunc);

        }

        public static void Print(Func<int, int, int> sumFunc)
        {
            var result = sumFunc(2, 4);
            Console.WriteLine(result);
        }

        public static void GetUser(Action<User> action)
        {
            var user = new User();
            action(user);
            Console.WriteLine($"User.Name = {user.Name} ,User.Family ={user.Family}, User.Age ={user.Age}");
        }
    }
}
