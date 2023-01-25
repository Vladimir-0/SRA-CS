using System;
using System.Linq;

namespace Serial_Root_Adder
{
    internal static class Utils
    {
        public static long Calculate(int amount)
        {
            return Enumerable.Range(0, amount).Select(i => (long)Math.Sqrt(i)).Sum();
        }
    }
}
