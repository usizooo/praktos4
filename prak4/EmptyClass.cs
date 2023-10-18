using System;
namespace заметки
{
    internal class Menu
    {
        static Note q = new()
        {
            name = "  Полить цветы",
            info = "  На балконе и у мамы в комнате",
            data = new DateTime(2023, 10, 18)
        };
        static Note w = new()
        {
            name = "  Сходить на пары",
            info = "  с первой по третью",
            data = new DateTime(2023, 10, 18)
        };
        static Note e = new()
        {
            name = "  Приготовить ужин",
            info = "  Макароны с сосисками на двух человек",
            data = new DateTime(2023, 10, 21)
        };
        static Note r = new()
        {
            name = "  Помыть окна",
            info = "  На балконе",
            data = new DateTime(2023, 10, 21)
        };
        static Note t = new()
        {
            name = "  Сходить на тренировку",
            info = "  Потренироваться в спортзале с 18:00 до 20:00",
            data = new DateTime(2023, 10, 25)
        };
        static Note y = new()
        {
            name = "  Сходить к бабушке",
            info = "  Отнести пирог и новый чайник",
            data = new DateTime(2023, 10, 25)
        };
        public static Note[] zametka = { q, w, e, r, t, y };
        public static List<Note> zametki = new();
        public static DateTime date = DateTime.Now;
        public static int Strelochki (int min, int max)
        {


            int pos = 1;
            date = DateTime.Now;
            ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("   ");

                if (key.Key == ConsoleKey.UpArrow && pos != min)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != max)
                {
                    pos++;
                }

                ChangeData(key);
                Console.SetCursorPosition(1, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }
            return pos;
        }

        public static void ChangeData(ConsoleKeyInfo info)
        {
            if (info.Key == ConsoleKey.RightArrow)
            {
                zametki.Clear();
                Console.SetCursorPosition(0, 0);
                date = date.AddDays(1);
                Console.Clear();
                Console.WriteLine(date.ToString());
                foreach (Note a in zametka)
                {
                    if (a.data.Date == date.Date)
                    {
                        Console.WriteLine("  " + a.name);
                        zametki.Add(a);
                    }
                }
            }
            else if (info.Key == ConsoleKey.LeftArrow)
            {
                zametki.Clear();
                Console.SetCursorPosition(0, 0);
                date = date.AddDays(-1);
                Console.Clear();
                Console.WriteLine(date.ToString());
                foreach (Note a in zametka)
                {
                    if (a.data.Date == date.Date)
                    {
                        Console.WriteLine("  " + a.name);
                        zametki.Add(a);
                    }
                }
            }

        }
    }
}