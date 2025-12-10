using Tyuiu.NesterenkoVV.Sprint6.Task5.V11.Lib;
namespace Tyuiu.NesterenkoVV.Sprint6.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V11.txt";

            DataService ds = new DataService();

            double[] waitArray = new double[3] {5, 0, -5};
            var resultArray = ds.LoadFromDataFile(path);


            CollectionAssert.AreEqual(waitArray, resultArray);
        }
    }
}
