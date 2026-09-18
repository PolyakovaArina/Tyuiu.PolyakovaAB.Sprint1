using Tyuiu.PolyakovaAB.Sprint1.Task6.V10.Lib;
namespace Tyuiu.PolyakovaAB.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string a = "dfghj hgf gt fghjkll";
            Assert.AreEqual("dfhj hf gt fghkll",ds.DeleteMiddleLetter(a));
        }
    }
}
