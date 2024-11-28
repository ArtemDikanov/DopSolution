using Library2;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = ds.Metod2(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.Metod2(startValue, stopValue);

            Console.WriteLine("+------------+-------------+");
            Console.WriteLine("|     X      |      f(x)   |");
            Console.WriteLine("+------------+-------------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("| {0,5:d}      |   {1, 6:f2}    |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+------------+-------------+");
            Console.ReadKey();
        }
    }
}
