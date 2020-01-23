using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение переменной A: ");
            string A = Console.ReadLine();
            A = A.Replace('.', ',');
            if (double.TryParse(A, out double a))
            {
                Console.Write("Введите значение переменной B: ");
                string B = Console.ReadLine();
                B = B.Replace('.', ',');
                if (double.TryParse(B, out double b))
                {
                    double temp = a;
                    a = b;
                    b = temp;
                    Console.WriteLine("\nОбмен значений переменных:");
                    Console.WriteLine($"A = {a}");
                    Console.WriteLine($"B = {b}");
                }
                else
                {
                    Console.Write("Значение переменной B введено неверно");
                }
            }
            else
            {
                Console.Write("Значение переменной A введено неверно.");
            }

            Console.ReadKey(true);
        }
    }
}
