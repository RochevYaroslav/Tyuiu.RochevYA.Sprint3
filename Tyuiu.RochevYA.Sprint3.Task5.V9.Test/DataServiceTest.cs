using Tyuiu.RochevYA.Sprint3.Task5.V9.Lib;
namespace Tyuiu.RochevYA.Sprint3.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1935, ds.GetSumSumSeries(5,1,3,1,14));
        }
    }
}
