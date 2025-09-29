using Tyuiu.RochevYA.Sprint3.Task3.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        char chor = 'e';
        string text = "have a nice time";
        Console.WriteLine(ds.GetCharCount(text,chor));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}