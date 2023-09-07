using System;

namespace DZ2;
class Progrem
{
    static void Main(string[] args)
    {

        Console.WriteLine("Задание 2 Программа просит пользователя ввести 2 числовые переменные. А после она меняет их местами и выводит результат на экран.");

        Console.WriteLine("Введите первое число");
        string chis1 = Console.ReadLine();
        chis1 = chis1.Replace(',', '.');
        if (!int.TryParse(chis1, out int chis1_int) || !double.TryParse(chis1, out double chis1_doub))
        {
        }
        else
        {
            Console.WriteLine("Вы ввели не число");
        }


        Console.WriteLine("Введите второе число");
        string chis2 = Console.ReadLine();
        chis2 = chis2.Replace(',', '.');
        if (!int.TryParse(chis2, out int chis2_int) || !double.TryParse(chis1, out double chis2_doub))
        {
        }
        else
        {
            Console.WriteLine("Вы ввели не число");
        }
        Console.WriteLine("Результат:" + chis2 + " " + chis1);
        Console.WriteLine("Нажмите enter");
        Console.ReadKey();




    }
}