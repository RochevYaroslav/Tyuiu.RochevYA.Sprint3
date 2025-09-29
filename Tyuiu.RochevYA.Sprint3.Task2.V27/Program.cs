using Tyuiu.RochevYA.Sprint3.Task2.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 5;
        int start = 1;
        int end = 14;
        Console.WriteLine(ds.GetSumSeries(x, start, end));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}