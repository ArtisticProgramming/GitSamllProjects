using System;
using System.Threading;

namespace Thread_
{
    class Program
    {
        static int Total = 0;
        static object _lock = new object();

        public static void Main()
        {

            Thread thread1 = new Thread(Program.AddOneMillion);
            Thread thread2 = new Thread(Program.AddOneMillion);
            Thread thread3 = new Thread(Program.AddOneMillion);
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread1.Join();
            thread2.Join();
            thread3.Join();
            Console.WriteLine("Total = " + Total);
            Console.ReadLine();
        }
        public static void AddOneMillion()
        {

            for (int i = 1; i <= 1000; i++)
            {
                //Without lock the Total value is not correct. 
                //lock used to protect Total value because ++ is not thread-safe operation.
                lock (_lock)
                {
                    //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    Total++;
                    //Console.WriteLine(Total);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
