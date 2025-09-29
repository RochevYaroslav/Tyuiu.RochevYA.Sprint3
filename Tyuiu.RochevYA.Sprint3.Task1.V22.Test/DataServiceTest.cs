using Tyuiu.RochevYA.Sprint3.Task1.V22.Lib;
namespace Tyuiu.RochevYA.Sprint3.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1935, ds.GetSumSeries(1.5, 1, 15));
        }
    }
}
