using System;
using System.Collections.Generic;
using System.Text;

class River
{
    public string Name { get; set; }
    public double Length { get; set; }
    public double BasinArea { get; set; }
    public List<string> Countries { get; set; }
    public bool IsNavigable { get; set; }

    public double GetAverageWidth()
    {
        return BasinArea / Length;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.Write("Введіть назву ріки: ");
        string name = Console.ReadLine();

        Console.Write("Введіть довжину ріки (в км): ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Введіть площу басейну (в кв. км): ");
        double basinArea = double.Parse(Console.ReadLine());

        Console.Write("Введіть країни, через які протікає ріка (розділяйте комами): ");
        string[] countriesArray = Console.ReadLine().Split(',');
        List<string> countries = new List<string>(countriesArray);

        Console.Write("Чи судноплавна ріка? (y-так, n-ні): ");
        bool isNavigable = Console.ReadKey().Key == ConsoleKey.Y;
        Console.WriteLine();

        River ourRiver = new River
        {
            Name = name,
            Length = length,
            BasinArea = basinArea,
            Countries = countries,
            IsNavigable = isNavigable
        };

        double averageWidth = ourRiver.GetAverageWidth();
        Console.WriteLine("\nІнформація про ріку:");
        Console.WriteLine($"Назва: {ourRiver.Name}");
        Console.WriteLine($"Довжина: {ourRiver.Length} км");
        Console.WriteLine($"Площа басейну: {ourRiver.BasinArea} кв. км");
        Console.WriteLine($"Країни: {string.Join(", ", ourRiver.Countries)}");
        Console.WriteLine($"Судноплавна: {(ourRiver.IsNavigable ? "так" : "ні")}");
        Console.WriteLine($"Середня ширина ріки: {averageWidth} км");
        Console.ReadLine();
    }
}
