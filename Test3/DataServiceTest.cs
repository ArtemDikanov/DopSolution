using Library3;
namespace Test3
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "246813579";
            int wait = 4;
            int res = ds.Metod3(n, m, str);
            Assert.AreEqual(wait, res);
        }
    }
}//