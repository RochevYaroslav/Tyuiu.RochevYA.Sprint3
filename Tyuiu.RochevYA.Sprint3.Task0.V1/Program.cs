using Tyuiu.RochevYA.Sprint3.Task0.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 4;
        int start = 1;
        int end = 15;
        Console.WriteLine(ds.GetSumSeries(x,start, end));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}