using System;

namespace MyLib
{
    public class MathHelper
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Привет, {name}!");
        }

        public void PrintMultiplicationTable(int number)
        {
            Console.WriteLine($"Таблица умножения для {number}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль!");
            return (double)a / b;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}