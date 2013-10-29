using System;

namespace GetFactorialWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial f = new Factorial();
            long result = f.getFactorial(20);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    public class Factorial
    {
        public long getFactorial(long x)
        {
            if (x == 1)
                return x;
            x *= getFactorial(x - 1);
            return x;
        }
    }
}
