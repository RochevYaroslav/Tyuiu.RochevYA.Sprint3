using Tyuiu.RochevYA.Sprint3.Task0.V1.Lib;

namespace Tyuiu.RochevYA.Sprint3.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1935, ds.GetSumSeries(4, 1,15));
        }
    }
}
