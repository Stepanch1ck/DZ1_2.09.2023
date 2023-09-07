using System;

namespace DZ4;

class Progrem
{
    static void Main(string[] args)
    {
        Console.WriteLine("4 задание");
        Console.WriteLine("Найти значение y=cos(x)");
        Console.WriteLine("Введите y в градусах:");
        string input1 = Console.ReadLine();
        double y1 = Convert.ToDouble(input1);
        Console.WriteLine(Math.Cos(y1 * Math.PI / 180));
        Console.WriteLine("Введите y в радианах(дробное число без Pi):");
        string input2 = Console.ReadLine();
        double y2 = Convert.ToDouble(input2);
        Console.WriteLine(Math.Cos(y2));
        Console.WriteLine("Нажмите, чтобы закрыть");
        Console.ReadKey();


    }
}
