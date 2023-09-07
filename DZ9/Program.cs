using System;

namespace DZ9;

class Progrem
{
    static void Main(string[] args)
    {
        Console.WriteLine("9 задание");
        Console.WriteLine("Известна стоимость 1 кг конфет, 1 кг печенья и 1 кг яблок. Найти стоимость всей\r\nпокупки, если купили x кг конфет, у кг печенья и z кг яблок.");

        Console.WriteLine("Введите стоимость 1 кг конфет, печенья, яблок через пробел");
        string input_price = Console.ReadLine();
        string[] price = input_price.Split(" ");
        double c_price = double.Parse(price[0]);
        double b_price = double.Parse(price[1]);
        double a_price = double.Parse(price[2]);

        Console.WriteLine("Введите массу конфет, печенья, яблок через пробел");
        string input_massa = Console.ReadLine();
        string[] massa = input_massa.Split(" ");
        double c_massa = double.Parse(massa[0]);
        double b_massa = double.Parse(massa[1]);
        double a_massa = double.Parse(massa[2]);

        Console.WriteLine("Итого:" + ((c_price*c_massa)+(b_price*b_massa)+(a_price*a_massa)));
        Console.WriteLine("Нажмите enter");
        Console.ReadKey();


    }
}
