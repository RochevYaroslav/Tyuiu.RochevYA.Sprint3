using Tyuiu.RochevYA.Sprint3.Task6.V21.Lib;
namespace Tyuiu.RochevYA.Sprint3.Task6.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1935, ds.GetSumTheDivisors(5,10));
        }
    }
}
