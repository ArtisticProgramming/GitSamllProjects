using System;

namespace Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                calculateZeroDevision();
            
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void calculateZeroDevision()
        {
            var zero = 0;
            var s = 2 / zero;
        }
    }
}
