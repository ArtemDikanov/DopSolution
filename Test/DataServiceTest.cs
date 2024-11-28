using Library;
namespace Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0.1;
            double y = 0.2;

            bool wait = false;

            bool res = ds.Metod1(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}