using Tyuiu.NesterenkoVV.Sprint6.Task6.V16.Lib;
namespace Tyuiu.NesterenkoVV.Sprint6.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V16.txt";
            string wait = "bee block abs";
            Assert.AreEqual(ds.CollectTextFromFile(path), wait);
        }
    }
}
