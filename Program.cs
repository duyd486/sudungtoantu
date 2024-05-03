internal class Program
{
    private static void Main(string[] args)
    {
        float width;
        float height;
        Console.WriteLine("Nhap chieu dai: ");
        width = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu rong: ");
        height = float.Parse(Console.ReadLine());
        float area = width * height;
        Console.WriteLine("Dien tich hinh chu nhat la: " + area);
    }
}