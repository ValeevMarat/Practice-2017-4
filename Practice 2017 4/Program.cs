using System;

// Задание №4 практики 2017г. 
// Задание 119г: Вычислить бесконечную сумму с заданной точностью ε (ε>0). Считать что требуемая точность достигнута, если несколько первых слагаемых и очередное слагаемое оказалось по модулю меньше , чем ε, это и все последующие слагаемые можно уже не учитывать. 
// Ссылка на "Задачи по программированию": http://aesa.kz:8081/computer-science/abramov.pdf

namespace Practice_2017_4
{
    class Program
    {
        static double CountInfSum()
        {
            Console.Write("Введите точность: ");
            double eps = double.Parse(Console.ReadLine()), sum = 0, nextEl = 1;
            long fact = 1;                                     // Переменная для хранения факториала
            for (int i = 1; Math.Abs(sum + nextEl) > eps; i++) // Считать до заданной точности
            {
                sum += nextEl;
                fact *= i;
                nextEl = Math.Pow(-2, i) / fact;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nБесконечная сумма (по формуле: ((-2)^i)/i!, i=0) с заданной точностью (eps>0)= " + CountInfSum());
            Console.ReadLine();
        }
    }
}
