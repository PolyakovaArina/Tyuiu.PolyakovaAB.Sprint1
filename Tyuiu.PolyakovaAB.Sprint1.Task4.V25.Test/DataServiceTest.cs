using Tyuiu.PolyakovaAB.Sprint1.Task4.V25.Lib;
namespace Tyuiu.PolyakovaAB.Sprint1.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2;
            Assert.AreEqual(Math.Round((1 - Math.Cos(a)) / (Math.Pow(Math.Sin(a), 2)),3), ds.Calculate(a));
        }
    }
}
