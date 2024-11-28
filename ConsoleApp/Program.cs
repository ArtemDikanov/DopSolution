using Library;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите координату Х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.Metod1(x, y);

            if (res)
            {
                Console.WriteLine("Точка находится в закрашенной области.");
            }
            else
            {
                Console.WriteLine("Точка НЕ находится в закрашенной области.");
            }
            Console.ReadKey();
        }
    }
}
