using System;
using System.Linq;
namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int,int> Fib = null;
            Fib = (x) => x > 1 ? Fib(x-1) + Fib(x-2) : x;
            Console.WriteLine(Fib(1));
        }
    }
}
