using Tyuiu.GairabekovMR.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GairabekovMR.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // вызов класса DataService и метода GetMessage
            // из библиотеки Tyuiu.GairabekovMR.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Муса"));
            Console.ReadKey();
            
        }
    }
}
