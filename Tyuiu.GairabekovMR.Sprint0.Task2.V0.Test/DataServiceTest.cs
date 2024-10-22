using Tyuiu.GairabekovMR.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GairabekovMR.Sprint0.Task2.V0.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Муса";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, Муса", res);
        }
    }
}