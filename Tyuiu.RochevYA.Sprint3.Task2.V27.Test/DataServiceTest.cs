using Tyuiu.RochevYA.Sprint3.Task2.V27.Lib;
namespace Tyuiu.RochevYA.Sprint3.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1935, ds.GetSumSeries(5, 1, 14));
        }
    }
}
