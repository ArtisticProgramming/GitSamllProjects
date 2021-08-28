using System;
using System.Collections.Generic;

namespace Iterators
{
    class Program
    {
        static void Main()
        {
  
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("1", "one");
            dic.Add("2", "Two");
            dic.Add("3", "Three");
            foreach (KeyValuePair<string, string> entry in dic)
            {
                Console.WriteLine($"key:{entry.Key} value:{entry.Value}");
                // do something with entry.Value or entry.Key
            }


            foreach (int number in EvenSequence(1, 50))
            {
                Console.Write(number.ToString() + " ");
            }
            // Output: 6 8 10 12 14 16 18
            Console.ReadKey();
        }

        public static System.Collections.Generic.IEnumerable<int>
            EvenSequence(int firstNumber, int lastNumber)
        {
            // Yield even numbers in the range.
            for (int number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}
