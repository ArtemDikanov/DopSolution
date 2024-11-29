namespace Library3
{
    public class DataService
    {
        public int Metod3(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        count ++;
                    }
                }
            }

            return count;
        }
    }//
}
