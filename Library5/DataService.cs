
namespace Library5
{
    public class DataService
    {
        public double GetMatrix(int[,] array, int n1, int n2, int c, int k, int l)
        {
            Random rnd = new Random();

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows; 

            double sum = 0;
            double count = 0;
            double result = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                   
                    if ((j != c) || ((j == c) && ((i < k) | (i > l))))
                    {
                        sum += array[i, j];
                        count++;

                    }

                }
                //Console.WriteLine();
            }
            //for (int i = 0; i < rows; i++)
            //{
                //for (int j = 0; j < columns; j++)
                //{
                    //Console.Write($"{matrix[i, j]} \t");
                //}
                //Console.WriteLine();
            //}


            result = sum / count;
            return Math.Round(result, 3);
        }
    }
}
