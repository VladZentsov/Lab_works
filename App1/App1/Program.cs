using System;
using System.Linq;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            double a = double.Parse(Console.ReadLine());//ввод и преобразования в double члена a
            Console.WriteLine("Введите d");
            double d = double.Parse(Console.ReadLine());//ввод и преобразования в double члена d
            Console.WriteLine("Введите n");
            double n =(int)(double.Parse(Console.ReadLine()));//ввод и преобразования в int члена n
            double res = a + (n - 1) * d;//вычесления n-го члена
            Console.WriteLine("n-й член арифметической прогренссии = "+Math.Round(res,2));//вывод результата с округлением до двух знаков
            Console.ReadKey();//ожидание завершения 
        }
    }
}
