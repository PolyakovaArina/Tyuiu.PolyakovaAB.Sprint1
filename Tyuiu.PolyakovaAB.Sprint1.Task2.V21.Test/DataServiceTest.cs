using Tyuiu.PolyakovaAB.Sprint1.Task2.V21.Lib;
namespace Tyuiu.PolyakovaAB.Sprint1.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds=new DataService();
            int value = 2;
            int ValueTwo = 1;
            Assert.AreEqual(value * ValueTwo, ds.CalculateRectangleSquare(value,ValueTwo));
        }
    }
}
