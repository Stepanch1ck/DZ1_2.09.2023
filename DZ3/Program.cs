using System;

namespace DZ3;

class Progrem
{
    static void Main(string[] args)
    {
        Console.WriteLine("3 задание");
        Console.WriteLine("Дан радиус окружности. Найти длину окружности и площадь круга.");
        Console.WriteLine("Введите радиус окружности");
        string radiuss = Console.ReadLine();
        double rad = Convert.ToDouble(radiuss);
        Console.WriteLine("Длина:" + 2 * Math.PI * rad);
        Console.WriteLine("Площадь:" + Math.PI * rad * rad);
        Console.WriteLine("Нажмите, чтобы закрыть");
        Console.ReadKey();


    }
}
