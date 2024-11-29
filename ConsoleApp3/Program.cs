using Library3;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "246813579";

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int res = ds.Metod3(n, m, str);

            Console.WriteLine("Ответ: " + res);
            Console.ReadKey();
        }
    }
}//
