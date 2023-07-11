namespace Project_2;

public class Inf_booking
{
    
    public static void adminget(string bk)
    {
        Console.Clear();
        Console.Write("Проверка бронирования");
        if (bk.Length == 6 || bk.Length == 1)
        {
            Console.Clear();
            Console.WriteLine("\nИнформация о бронировании: \n");
            
            ///ПРОВЕРКА НА УЖЕ РАНДОМИЗИРОВАННЫХ РАХ
            string flight = Database.get_string("booking", "book_num", bk, 2); //из номера брони получаем номер рейса
            string typ = Database.get_string("flight_number", "num", flight, 4); //из номера рейса получаем тип ВС
            string plane_size = Database.get_string("airplane", "plain_type", typ, 1); //из типа ВС получаем размер ВС
            if (Database.get_string("booking", "book_num", bk, 5) != "")
            {
                Airplane.Airplane.salon(plane_size, flight, bk);
                Console.WriteLine("\nНажмите любую клавишу, чтобы выйти в главное меню");
                Console.ReadKey();
                Main.menu();
            }
            else
            {
                Database.get_book_string("booking", bk);
                Console.WriteLine("\nНажмите любую клавишу, чтобы выйти в главное меню");
                Console.ReadKey();
                Main.menu();
            }
        }
        else if (bk == "/exit")
        {
            Admin.menu();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nНомер брони некорретный, нажмите любую клавишу, чтобы ввести снова.");
            Console.ResetColor();
            Console.ReadKey();
            adminget(bk);
        }
    }
    public static void gget()
    {
        Console.Clear();
        Console.Write("Система проверки бронирования\nВведите номер брони: ");
        Console.ForegroundColor = ConsoleColor.Green;
        string? bk = Console.ReadLine();
        Console.ResetColor();
        if (bk.Length == 6 || bk.Length == 1)
        {
            Console.Clear();
            Console.WriteLine("\nИнформация о бронировании: \n");


            ///ПРОВЕРКА НА УЖЕ РАНДОМИЗИРОВАННЫХ РАХ
            string flight = Database.get_string("booking", "book_num", bk, 2); //из номера брони получаем номер рейса
            string typ = Database.get_string("flight_number", "num", flight, 4); //из номера рейса получаем тип ВС
            string plane_size = Database.get_string("airplane", "plain_type", typ, 1); //из типа ВС получаем размер ВС
            if (Database.get_string("booking", "book_num", bk, 5) != "")
            {
                Airplane.Airplane.salon(plane_size, flight, bk);
                Console.WriteLine("\nНажмите любую клавишу, чтобы выйти в главное меню");
                Console.ReadKey();
                Main.menu();
            }
            else
            {
                Database.get_book_string("booking", bk);
                Console.WriteLine("\nНажмите любую клавишу, чтобы выйти в главное меню");
                Console.ReadKey();
                Main.menu();
            }
        }
        else if (bk == "/exit")
        {
            Main.menu();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nНомер брони некорретный, нажмите любую клавишу, чтобы ввести снова.");
            Console.ResetColor();
            Console.ReadKey();
            get();
        }
    }

    public static void get()
    {
        Console.Clear();
        Console.WriteLine("\nСистема проверки бронирования\n1 - Приступить к проверке\n2 - Назад");
        ConsoleKeyInfo moveKey = Console.ReadKey();
        switch (moveKey.Key)
        {
            case ConsoleKey.D2:
                Main.menu();
                break;
            default:
                gget();
                break;
        }
    }
}