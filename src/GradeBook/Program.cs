using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        // concatenation vs interpolation
        {
            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
                Console.WriteLine($"Hello, {args[1]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
