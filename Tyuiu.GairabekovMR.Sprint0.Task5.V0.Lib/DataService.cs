﻿
namespace Tyuiu.GairabekovMR.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        //Пример линейной структуры
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        //Пример линейной структуры
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        //Пример линейной структуры
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }


        //Пример линейной структуры
        public static double Division(int a, int b)
        {
            if (b == 0)
            {
                // Пример создан в целях демонстрации ветвления
                // В реальных проектах нужно использовать Exception 
                Console.WriteLine("Переменная b = {0} на ноль делить нельзя", b);
                return -1;

            }
            else
            {
                return a / b;
            }
        }
    }
}
