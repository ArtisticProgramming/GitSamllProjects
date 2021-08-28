using System;
using System.Threading;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {


            Bus s = new Bus();

            Console.WriteLine(Bus.InitDateTime);
            Thread.Sleep(2000);
            Bus ss = new Bus();

            Console.WriteLine(Bus.InitDateTime);
            Console.ReadKey();
        }

    }

    public  class Bus
    {
        public static DateTime InitDateTime { get; set; }
        static Bus()
        {
            InitDateTime = DateTime.Now;
        }


    }
}
