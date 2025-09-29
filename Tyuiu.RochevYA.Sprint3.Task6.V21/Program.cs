using Tyuiu.RochevYA.Sprint3.Task6.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int start = 19;
        int end = 30;
        Console.WriteLine(ds.GetSumTheDivisors(start,end));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}