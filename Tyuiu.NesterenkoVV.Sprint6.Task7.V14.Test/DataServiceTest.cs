using Tyuiu.NesterenkoVV.Sprint6.Task7.V14.Lib;
namespace Tyuiu.NesterenkoVV.Sprint6.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            string path = @"C:\DataSprint5\InPutFileTask7V14.csv";
            int[,] wait = new int[4, 3] { { 2, 1, 3 }, { 2, 2, 4 }, { 44, 5, 44 }, { 2, 4, 6 } };
            CollectionAssert.AreEqual(ds.GetMatrix(path), wait);
        }
    }
}
