using Tyuiu.NesterenkoVV.Sprint6.Task1.V6.Lib;
namespace Tyuiu.NesterenkoVV.Sprint6.Task1.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 0;
            int y = 0;
            var res = ds.GetMassFunction(x, y);
            double[] wait = new double[2] {2, -0.5};
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
