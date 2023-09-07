using System;

namespace DZ5;

class Progrem
{
    static void Main(string[] args)
    {
        Console.WriteLine("5 задание");
        Console.WriteLine("Найти корни квадратного уравнения");
        Console.WriteLine("Введите коэффициент a, b, c квадратного уравнения через пробел");
        string input = Console.ReadLine();
        string[] coef = input.Split(" ");
        double a = double.Parse(coef[0]);
        double b = double.Parse(coef[1]);
        double c = double.Parse(coef[2]);
        Console.WriteLine("{0}x*x+{1}x+{2}=0", a, b, c);
        double D = b * b - 4 * a * c;
        if (D > 0)
        {
            Console.WriteLine("x1=" + (-b + Math.Sqrt(D) / 2 * a));
            Console.WriteLine("x2=" + (-b + Math.Sqrt(D) / 2 * a));
        }
        else if (D == 0)
        {
            Console.WriteLine("x=" + -b / 2 * a);
        }
        else
        {
            Console.WriteLine("Нет действительных корней");
        }
        Console.WriteLine("Нажмите enter");
        Console.ReadKey();


    }
}
