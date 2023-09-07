using System;

namespace DZ8;

class Progrem
{
    static void Main(string[] args)
    {
        Console.WriteLine("8 задание");
        Console.WriteLine("Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале.");
        Console.WriteLine("Введите трехзначное число");
        string number = Console.ReadLine();
        char last = number.Last();
        number= number.Remove(number.Length -1);
        Console.WriteLine(last+number);
        Console.WriteLine("Нажмите enter");
        Console.ReadKey();


    }
}
