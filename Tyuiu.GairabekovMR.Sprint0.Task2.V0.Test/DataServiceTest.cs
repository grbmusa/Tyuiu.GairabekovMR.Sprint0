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
            // ������� �������� ������� ������������, ������� �� ����������
            var name = "����";
            var res = DataService.GetMessage(name);

            // �������� ����� Assert � ����� AreEqual
            Assert.AreEqual("������, ����", res);
        }
    }
}