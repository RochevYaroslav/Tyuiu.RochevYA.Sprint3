using Tyuiu.RochevYA.Sprint3.Task3.V26.Lib;

namespace Tyuiu.RochevYA.Sprint3.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1935, ds.GetCharCount("hello",'e'));
        }
    }
}
