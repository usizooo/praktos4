using System;
using заметки;



DateTime data;

do
{
    data = Menu.date;
    Console.WriteLine(Menu.date.ToString());
    foreach (Note a in Menu.zametka)
    {
        if (a.data.Date == data.Date)
        {
            Console.WriteLine("  " + a.name);
            Menu.zametki.Add(a);

        }
    }

    int pos = Menu.Strelochki(1, Menu.zametki.Count);



    if (pos == 1)
    {
        Console.Clear();

        Console.WriteLine(Menu.zametki[0].name);
        Console.WriteLine(Menu.zametki[0].info);
        Console.WriteLine("Дата выполнения:");
        Console.WriteLine(Menu.zametki[0].data);
    }
    else if (pos == 2)
    {
        Console.Clear();

        Console.WriteLine(Menu.zametki[1].name);
        Console.WriteLine(Menu.zametki[1].info);
        Console.WriteLine("Дата выполнения:");
        Console.WriteLine(Menu.zametki[1].data);
    }
    Console.WriteLine("Нажмите Enter, чтобы продолжить");
    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
    Console.Clear();

} while (true);

class Note
{
    public string name;
    public string info;
    public DateTime data;
}


