using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                Console.WriteLine($"Факториал числа {number} = {Factorial(number)}");
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }

        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}