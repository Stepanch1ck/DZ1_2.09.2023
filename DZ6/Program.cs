using System;

namespace DZ6;

class Progrem
{
    static void Main(string[] args)
    {
        Console.WriteLine("6 задание");
        Console.WriteLine("Программа обмена значениями трех переменных величин а, b, c");
        Console.WriteLine("Введите значения для способа а. a, b, c через пробел");
        string input1 = Console.ReadLine();
        string[] coef1 = input1.Split(" ");
        double a1 = double.Parse(coef1[0]);
        double b1 = double.Parse(coef1[1]);
        double c1 = double.Parse(coef1[2]);
        double temp1 = c1;
        c1 = a1; a1 = b1; b1 = temp1;
        Console.WriteLine("a:"+ a1 + b1 + c1) ;
        Console.WriteLine("Введите значения для способа b. a, b, c через пробел");
        string input2 = Console.ReadLine();
        string[] coef2 = input2.Split(" ");
        double a2 = double.Parse(coef2[0]);
        double b2 = double.Parse(coef2[1]);
        double c2= double.Parse(coef2[2]);
        double temp2 = a2;
        a2 = c2; c2 = b2; b2 = temp2;
        Console.WriteLine("b:" + a2 + b2 + c2);
        Console.WriteLine("Нажмите enter");
        Console.ReadKey();


    }
}
