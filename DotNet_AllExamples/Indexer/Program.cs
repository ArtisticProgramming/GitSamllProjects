using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new DayCollection();

            var day = s["Wed"];
            Console.WriteLine($"day index:{day}");
            Console.Read();
        }
    }

    // Using a string as an indexer value
    public class DayCollection
    {
        string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };

        // Indexer with only a get accessor with the expression-bodied definition:
        public int this[string day] => FindDayIndex(day);

        private int FindDayIndex(string day)
        {
            for (int j = 0; j < days.Length; j++)
            {
                if (days[j] == day)
                {
                    return j;
                }
            }

            throw new ArgumentOutOfRangeException(
                nameof(day),
                $"Day {day} is not supported.\nDay input must be in the form \"Sun\", \"Mon\", etc");
        }
    }
}