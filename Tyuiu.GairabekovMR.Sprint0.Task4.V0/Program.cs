﻿using Tyuiu.GairabekovMR.Sprint0.Task4.V0.Lib;
namespace Tyuiu.GairabekovMR.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры программы
            //Вызов метода сложения Addition
            Console.WriteLine(DataService.Addition(1, 5));
            //Вызов метода вычитания Subtraction
            Console.WriteLine(DataService.Subtraction(15, 5));
            //Вызов метода умножения Multiplication
            Console.WriteLine(DataService.Multiplication(10, 10));
            //Вызов метода деления Devision
            Console.WriteLine(DataService.Devision(5, 5));


            Console.ReadKey();
        }
    }
}
