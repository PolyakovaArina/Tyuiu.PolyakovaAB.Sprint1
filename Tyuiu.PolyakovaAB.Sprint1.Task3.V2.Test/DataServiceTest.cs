using Tyuiu.PolyakovaAB.Sprint1.Task3.V2.Lib;
namespace Tyuiu.PolyakovaAB.Sprint1.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            float a =2;
            int b =2;
            float c =2;
            int d =2;
            Assert.AreEqual(Math.Round(a * b + c * d,3), ds.PurchaseAmount(a, b, c, d));
        }
    }
}
