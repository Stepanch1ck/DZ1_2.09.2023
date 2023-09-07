using System;

namespace DZ7;

class Progrem
{
    static void Main(string[] args)
    {
        Console.WriteLine("7 задание");
        Console.WriteLine("Четыре случайных числа столбиком");
        Random rand = new Random();
        Console.WriteLine(rand.Next());
        Console.WriteLine(rand.Next());
        Console.WriteLine(rand.Next());
        Console.WriteLine(rand.Next());
        Console.WriteLine("Нажмите enter");
        Console.ReadKey();


    }
}
