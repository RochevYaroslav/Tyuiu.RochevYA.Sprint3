using Tyuiu.RochevYA.Sprint3.Task5.V9.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 5;
        int sta1 = 1;
        int end1 = 3;
        int sta2 = 1;
        int end2 = 14;
        Console.WriteLine(ds.GetSumSumSeries(x,sta1,sta2,end1, end2));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}