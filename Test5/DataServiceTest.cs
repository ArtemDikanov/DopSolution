using Library5;
namespace Test5
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5];
            int n1 = 0;
            int n2 = 1;
            int c = 4;
            int k = 0;
            int l = 4;

            double wait = 0.5;
            double res = ds.GetMatrix(array, n1, n2, c, k, l);

            Assert.AreEqual(wait, res);
        }
    }
}