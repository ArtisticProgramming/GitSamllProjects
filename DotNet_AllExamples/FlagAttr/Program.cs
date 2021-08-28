using System;

namespace FlagAttr
{
    [Flags]
    public enum Color
    {
        red = 1,
        green = 2 << 0, //2
        blue = 2 << 1,  //4
        yellow = 2 << 2, //8
        Orange = 2 << 3, //16
    }
    class Program
    {
        static void Main(string[] args)
        {

            Color GoodColors = Color.red | Color.green | Color.Orange | Color.blue;

            //result is like 'red, green, blue, Orange' if you use Flag otherwise it is number
            Console.WriteLine($"Good Colors are: {GoodColors}");

            var r = GoodColors.HasFlag(Color.red);
            Console.WriteLine($"GoodColors Has this color '{Color.red}': {r}");
            Console.WriteLine($"green is: {(int)Color.green}");
            Console.ReadKey();
        }
    }
}
