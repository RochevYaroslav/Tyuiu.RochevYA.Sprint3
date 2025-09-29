using Tyuiu.RochevYA.Sprint3.Task7.V30.Lib;
namespace Tyuiu.RochevYA.Sprint3.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            CollectionAssert.AreEqual(, ds.GetMassFunction(-5, 5));
        }
    }
}
