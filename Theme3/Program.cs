using System;
using MyLib;

namespace Theme3
{
    class Program
    {
        static void Main()
        {
            var helper = new MathHelper();

            helper.SayHello("Иван");
            helper.PrintMultiplicationTable(3);

            int sum = helper.Add(10, 5);
            Console.WriteLine($"Add(10, 5) = {sum}");

            double div = helper.Divide(10, 4);
            Console.WriteLine($"Divide(10, 4) = {div}");

            bool even = helper.IsEven(7);
            Console.WriteLine($"IsEven(7) = {even}");
        }
    }
}