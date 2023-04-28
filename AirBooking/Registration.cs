using Project_2.Airplane;

namespace Project_2;

public class Registration
{
    public static void cchoice()
    {
        Console.Clear();
        Console.Write("\nВведите номер брони: ");
        Console.ForegroundColor = ConsoleColor.Red;
        string? bk = Console.ReadLine();
        Console.ResetColor();
        if (bk.Length == 6 || bk.Length == 1)
        {
            Console.Clear();
            string flight = Database.get_string("booking", "book_num", bk, 2);
            string typ = Database.get_string("flight_number", "num", flight, 4);
            string plane_size = Database.get_string("airplane", "plain_type", typ, 1);
            Airplane.Airplane.salon(plane_size, flight, bk);
            Console.WriteLine("\nНажмите любую клавишу, чтобы выйти в главное меню");
            Console.ReadKey();
            Main.menu();
        }
        else if(bk == "/exit")
        {
            Main.menu();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nНомер брони некорретный, нажмите любую клавишу, чтобы ввести снова.");
            Console.ResetColor();
            Console.ReadKey();
            choice();
        }
    }

    public static void choice()
    {
        Console.Clear();
        Console.WriteLine("\nСистема регистрации на рейс\n1 - Приступить к регистрации\n2 - Назад");
        ConsoleKeyInfo moveKey = Console.ReadKey();
        switch (moveKey.Key)
        {
            case ConsoleKey.D2:
                Main.menu();
                break;
            default:
                cchoice();
                break;
        }
    }
}