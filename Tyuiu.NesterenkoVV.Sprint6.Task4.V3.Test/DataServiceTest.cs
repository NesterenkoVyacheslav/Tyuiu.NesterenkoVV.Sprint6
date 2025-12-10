using Tyuiu.NesterenkoVV.Sprint6.Task4.V3.Lib;
namespace Tyuiu.NesterenkoVV.Sprint6.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int s = 0;
            int st = 0;
            var res = ds.GetMassFunction(s, st);
            double[] wait = new double[1] { 2.5 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
