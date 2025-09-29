using Tyuiu.RochevYA.Sprint3.Task4.V14.Lib;
namespace Tyuiu.RochevYA.Sprint3.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1935, ds.Calculate(-5, 5));
        }
    }
}
