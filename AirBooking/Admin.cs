namespace Project_2;

public class Admin
{
    public static void menu()
    {
        Console.Clear();
        Console.Write("Выберите:\n\n1 - Создать новый рейс\n2 - Удалить рейс\n3 - Список существующих рейсов\n4 - Бронирования\n5 - Управление самолетами\n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("6 - Выход в главное меню");
        Console.ResetColor();
        // Console.ForegroundColor = ConsoleColor.Green;
        // int ch = Convert.ToInt32(Console.ReadLine());
        // Console.ResetColor();
        ConsoleKeyInfo moveKey = Console.ReadKey();
        switch (moveKey.Key)
        {
            case ConsoleKey.D1: // СОЗДАНИЕ РЕЙСА
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("id\t\tNumber\t\tDepature\t\tArrival\t\t\tAirplane");
                Console.ResetColor();
                Database.get_table("flight_number", 5);
                Console.Write("\nВведите номер нового рейса: ");
                string? numb = Console.ReadLine();
                if (numb == "/exit")
                {
                    menu();
                }
                Console.Write("\nВведите аэропорт вылета: ");
                string? dep = Console.ReadLine();
                Console.Write("\nВведите аэропорт прибытия: ");
                string? arr = Console.ReadLine();
                Console.Write("\nВведите тип ВС: ");
                string? type = Console.ReadLine();
                Console.Clear();
                Database.new_flight(numb, dep, arr, type);
                Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню админа");
                Console.ReadKey();
                menu();
                break;
            case ConsoleKey.D2: //УДАЛЕНИЕ РЕЙСА
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("id\t\tNumber\t\tDepature\t\tArrival\t\t\tAirplane");
                Console.ResetColor();
                Database.get_table("flight_number", 5);
                Console.Write("\nВведите номер рейса, котрый требуется удалить(нажмите Enter, чтобы выйти): ");
                string? num_flight = Console.ReadLine();
                if (num_flight == "/exit")
                {
                    menu();
                }
                Database.delete_flight(num_flight);
                Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню админа");
                Console.ReadKey();
                menu();
                break;
            case ConsoleKey.D3: //GET FLIGHT
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("id\t\tNumber\t\tDepature\t\tArrival\t\t\tAirplane");
                Console.ResetColor();
                Database.get_table("flight_number", 5);
                Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню админа");
                Console.ReadKey();
                menu();
                break;
            case ConsoleKey.D4: //BOOKING
                Console.Clear();
                // Database.get_BOOK("booking");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("id\t\tNumber\t\tFlight\t\tNumb\t\tPAX");
                Console.ResetColor();
                Database.get_table("booking", 5);
                Console.WriteLine("\nВыберите:\n1 - Создать новое бронирование\n2 - Удалить бронирование\n3 - Информация о бронировании\n4 - Выход в меню админа");
                // Console.ForegroundColor = ConsoleColor.Green;
                // int sc = Convert.ToInt32(Console.ReadLine());
                // Console.ResetColor();
                
                ConsoleKeyInfo sc = Console.ReadKey();
                
                switch (sc.Key)
                {
                    case ConsoleKey.D1:
                        Ticket.creat();
                        choice();
                        break;
                    case ConsoleKey.D2:
                        Console.Write("Введите номер брони, для удаления: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        string? book = Console.ReadLine();
                        if (book == "/exit")
                        {
                            menu();
                        }
                        Console.ResetColor();
                        Database.delete("booking", "book_num", book);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nБронирование {book} удалено.");
                        Console.ResetColor();
                        Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню админа");
                        Console.ReadKey();
                        menu();
                        break;
                    case ConsoleKey.D3:
                        Console.Write("\nВведите номер брони: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string? bk = Console.ReadLine();
                        if (bk == "/exit")
                        {
                            menu();
                        }
                        Console.ResetColor();
                        // Console.Clear();
                        // Database.get_book_string("booking", bk);
                        Inf_booking.adminget(bk);
                        break;
                    case ConsoleKey.D4:
                        menu();
                        break;
                }
                Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню админа");
                Console.ReadKey();
                menu();
                break;
            case ConsoleKey.D5: //AIRPLANE
                Console.Clear();
                Console.WriteLine("Выберите:\n1 - Список ВС\n2 - Добавить ВС\n3 - Выход в меню админа");
                ConsoleKeyInfo pl = Console.ReadKey();
                // Console.ForegroundColor = ConsoleColor.Green;
                // int pl = Convert.ToInt32(Console.ReadLine());
                // Console.ResetColor();
                switch (pl.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Type\t\tSize\t\tQuantity\tPlaces\t\tName");
                        Console.ResetColor();
                        Database.get_table("airplane", 5);
                        Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню админа");
                        Console.ReadKey();
                        menu();
                        break;
                    case ConsoleKey.D2:
                        Airplane.Airplane.new_plane();
                        Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню админа");
                        Console.ReadKey();
                        menu();
                        break;
                    case ConsoleKey.D3:
                        menu();
                        break;
                    default:
                        menu();
                        break;
                }
                break;
            case ConsoleKey.D6: //EXIT
                Main.menu();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Еще не реализовано!");
                Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить");
                Console.ReadKey();
                menu();
                break;
        }
    }

    public static void choice()
    {
        Console.Clear();
        Console.WriteLine("\nСистема администратора\n1 - Войти\n2 - Назад");
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
    public static void cchoice()
    {
        Console.Clear();
        Console.Write("Войдите в аккаунт администратора\n\nВведите логин: ");
        Console.ForegroundColor = ConsoleColor.Red;
        string? login = Console.ReadLine();
        Console.ResetColor();
        Console.Write("Введите пароль: ");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        string? pass = Console.ReadLine();
        Console.ResetColor();

        if (login == "admin" && pass == "admin" || login == "a" && pass == "a")
        {
            menu();
        }
        else if (login == "/exit")
        {
            Main.menu();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Логин или пароль неверный!");
            Console.ResetColor();
            Console.WriteLine("\n\nВведите:\n1 - повторить попытку\n2 - выйти в главное меню");
            ConsoleKeyInfo gd = Console.ReadKey();
            // Console.ForegroundColor = ConsoleColor.Green;
            // int gd = Convert.ToInt32(Console.ReadLine());
            // Console.ResetColor();
            switch (gd.Key)
            {
                case ConsoleKey.D1:
                    choice();
                    break;
                case ConsoleKey.D2:
                    Main.menu();
                    break;
                default:
                    Console.WriteLine("Вы дурак?");
                    Console.ReadKey();
                    cchoice();
                    break;
            }
        }
    }
}