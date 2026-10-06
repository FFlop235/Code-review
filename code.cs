#!/usr/bin/env dotnet
using System;
using System.Numerics;

namespace Example
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Write("Введите число: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Неверный ввод: ожидается целое число.");
                return;
            }

            if (number < 0)
            {
                Console.WriteLine("Факториал определён только для неотрицательных чисел.");
                return;
            }

            Console.WriteLine($"Факториал числа {number} = {Factorial(number)}");
        }

        private static BigInteger Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n), "n должно быть >= 0.");

            BigInteger result = BigInteger.One;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}