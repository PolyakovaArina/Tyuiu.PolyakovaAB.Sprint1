using Tyuiu.PolyakovaAB.Sprint1.Task5.V2.Lib;
namespace Tyuiu.PolyakovaAB.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 303.5;
            Assert.AreEqual(Convert.ToInt32((a - 32) * 5 / 9), ds.FahrenheitToСelsius(a));

        }
    }
}
