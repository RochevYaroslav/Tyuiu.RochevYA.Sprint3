using Tyuiu.RochevYA.Sprint3.Task1.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        double a = 1.5;
        int start = 1;
        int end = 20;
        Console.WriteLine(ds.GetSumSeries(a, start, end));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}