﻿using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(89.1);

            // double[] numbers = new double[4] { 12.7, 10.3, 6.11, 4.1 }; <-- below is shorthand for this line
            var numbers = new [] { 12.7, 10.3, 6.11, 4.1 };
            // List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 }; <-- below is shorthand for this line
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
