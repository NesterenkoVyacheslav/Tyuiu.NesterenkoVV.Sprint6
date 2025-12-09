using Tyuiu.NesterenkoVV.Sprint6.Task3.V27.Lib;
namespace Tyuiu.NesterenkoVV.Sprint6.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[2, 5] { { -1, -2, -3, 4, 6}, {0, 2, 7, 7, 7} };
            int[,] wait = new int[2, 5] { { -1, -2, -3, 4, 6 }, { 0, 2, 7, 7, 7 } };
            CollectionAssert.AreEqual(wait, matrix);
        }
    }
}
