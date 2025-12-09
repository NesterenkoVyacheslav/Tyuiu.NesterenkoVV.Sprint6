using Tyuiu.NesterenkoVV.Sprint6.Task2.V23.Lib;
namespace Tyuiu.NesterenkoVV.Sprint6.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.GetMassFunction(0, 0);
            double[] wait = new double[1] {2.5};
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
