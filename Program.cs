using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
    //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).


    public delegate double Fun(double a, double x);

    class Program
    {

        //123
        static void Main()
        {

            Console.WriteLine("Таблица функции a*x^2:");

            NewClass.Function(NewClass.MyFunc, -1.5, -2, 2);

            Console.WriteLine("Таблица функции a*sin(x):");
            NewClass.Function(NewClass.MySin, 3, -2, 2);

            Console.ReadKey();
        }
    }
}
