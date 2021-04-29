using System;

namespace TestGit
{
    static class NewClass
    {
        //Метод, принимающий делегат

        public static void Function(Fun F, double a, double x, double b)
        {

            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }

        }

        //Метод возвращает значение функции a*x^2
        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        //Метод возвращает значение функции a*sin(x)
        public static double MySin(double a, double x)
        {
            return a * Math.Sin(x);
        }
    }
}
