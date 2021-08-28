using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class PrivateConstructor
    {
        //public void main()
        //{
        //    Counter s = new Counter(2, 3);

        //    Counter.currentCount = 20;
        //}
    }

    public class Counter
    {
        public int I { get; set; }
        public int B { get; set; }
        public Counter(int i, int b)
        {
            I = i;
            B = b;
        }
        private Counter() { }

        public static int currentCount;

        public static int IncrementCount()
        {
            return ++currentCount;
        }

        public class v
        {
            public v()
            {
                var s = new Counter();
            }
        }

    }
}
