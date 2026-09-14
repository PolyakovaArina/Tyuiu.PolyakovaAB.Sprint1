using Tyuiu.PolyakovaAB.Sprint1.Task1.V8.Lib;
namespace Tyuiu.PolyakovaAB.Sprint1.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double x = 2.0;
            Assert.AreEqual((x * 3.14) / a, ds.Calculate(a,x));
        }
    }
}
