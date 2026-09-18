using Tyuiu.PolyakovaAB.Sprint1.Task7.V18.Lib;
namespace Tyuiu.PolyakovaAB.Sprint1.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 4;
            Assert.AreEqual(5.168, ds.Calculate(x, y));
        }
    }
}
