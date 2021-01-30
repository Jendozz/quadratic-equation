using System;

namespace X_2.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
        Link1:
            Console.Clear();
            Console.WriteLine("Программа которая решает квадратное утравнение вида: a*x^2 + b*x + c\nВыберете номер пункта\n1.Решение уравнения\n2.Выход");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                (double, double, double) Tup = input();
                Calcul(ref Tup.Item1, ref Tup.Item2, ref Tup.Item3);
                goto Link1;

            }
            else if (ch == 2)
            {
                return;
            }
            else
            {
                Console.WriteLine("Неизвестный пункт. Нажмите любую кнопку для выхода в главное меню");
                Console.ReadKey();
                goto Link1;

            }

        }
        static (double, double, double) input()
        {
            Console.Clear();
            Console.WriteLine("Введите значения для коэффициентов");
            Console.WriteLine("Введите значения для коэффициента : a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значения для коэффициента : b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значения для коэффициента : c");
            double c = Convert.ToDouble(Console.ReadLine());
            return (a, b, c);
        }
        static void Calcul(ref double a, ref double b, ref double c)
        {
            Console.Clear();
            double x1;
            double x2;
            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("Дискриминант < 0\nУравнение не имеет корней.\nНажмите любую кнопку для выхода в главное меню.");
                Console.ReadKey();
                return;
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"Дискриминант равен 0. Уравнение имеет одине корень\nx ={x1}");
                Console.WriteLine("Нажмите любую кнопку для выхода в главное меню");
                Console.ReadKey();
            }
            else
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Дискриминант равен {D}. Уравнение имеет два корня\nx1 = {x1}\nx2 = {x2}");
                Console.WriteLine("Нажмите любую кнопку для выхода в главное меню");
                Console.ReadKey();
            }
        }
    }
}
