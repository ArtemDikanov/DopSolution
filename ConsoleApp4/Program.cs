using Library4;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V5.txt";
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V5.txt";
            Console.WriteLine("Результат: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
