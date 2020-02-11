using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string separator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            Console.Write("Введите первое число: ");
            string FirstNumber = Console.ReadLine();
            Console.Write("Введите второе число: ");
            string SecondNumber = Console.ReadLine();
            double parsedFirstNumber;
            double parsedSecondNumber;
            double temp;

            if (separator == ",")
            {
                FirstNumber = FirstNumber.Replace('.', ',');
                SecondNumber = SecondNumber.Replace('.', ',');

                if (double.TryParse(FirstNumber, out parsedFirstNumber) && double.TryParse(SecondNumber, out parsedSecondNumber))
                {
                    temp = parsedFirstNumber;
                    parsedFirstNumber = parsedSecondNumber;
                    parsedSecondNumber = temp;
                    Console.WriteLine("\nОбмен значений чисел:");
                    Console.WriteLine($"Первое число: {parsedFirstNumber}");
                    Console.WriteLine($"Второе число: {parsedSecondNumber}");
                }
                else
                {
                    Console.WriteLine("Ошибка при вводе чисел.");
                }
            }

            if (separator == ".")
            {
                FirstNumber = FirstNumber.Replace(',', '.');
                SecondNumber = SecondNumber.Replace(',', '.');

                if (double.TryParse(FirstNumber, out parsedFirstNumber) && double.TryParse(SecondNumber, out parsedSecondNumber))
                {
                    temp = parsedFirstNumber;
                    parsedFirstNumber = parsedSecondNumber;
                    parsedSecondNumber = temp;
                    Console.WriteLine("\nОбмен значений чисел:");
                    Console.WriteLine($"Первое число: {parsedFirstNumber}");
                    Console.WriteLine($"Второе число: {parsedSecondNumber}");
                }
                else
                {
                    Console.WriteLine("Ошибка при вводе чисел.");
                }
            }
            Console.ReadKey(true);
        }
    }
}
