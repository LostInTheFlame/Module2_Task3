using System;
using System.Collections.Generic;
using System.Globalization;


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string separator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            var replacement = new Dictionary<string, string> {
                {".", "," },
                {",", "." },
            };

            if (separator != "," && separator != ".")
            {
                Console.WriteLine("Разделитель целой и дробной части, установленный в системе, не поддерживается.");
                Console.ReadKey(true);
                return;
            }
            Console.Write("Введите первое число: ");
            string FirstNumber = Console.ReadLine();
            Console.Write("Введите второе число: ");
            string SecondNumber = Console.ReadLine();
            FirstNumber = FirstNumber.Replace(replacement[separator], separator);
            SecondNumber = SecondNumber.Replace(replacement[separator], separator);

            if (double.TryParse(FirstNumber, out double parsedFirstNumber) && double.TryParse(SecondNumber, out double parsedSecondNumber))
            {
                double temp = parsedFirstNumber;
                parsedFirstNumber = parsedSecondNumber;
                parsedSecondNumber = temp;
                Console.WriteLine("\nОбмен значений:");
                Console.WriteLine($"Первое число: {parsedFirstNumber}");
                Console.WriteLine($"Второе число: {parsedSecondNumber}");
            }
            else
            {
                Console.WriteLine("\nОшибка при вводе чисел.");
            }
            Console.ReadKey(true);
        }
    }
}
