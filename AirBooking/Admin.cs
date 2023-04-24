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
        Console.ForegroundColor = ConsoleColor.Green;
        int ch = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();
        switch (ch)
        {
            case 1: // СОЗДАНИЕ РЕЙСА
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("id\t\tNumber\t\tDepature\t\tArrival\t\t\tAirplane");
                Console.ResetColor();
                Database.get_table("flight_number");
                Console.Write("\nВведите номер нового рейса: ");
                string? numb = Console.ReadLine();
                Console.Write("\nВведите аэропорт вылета: ");
                string? dep = Console.ReadLine();
                Console.Write("\nВведите аэропорт прибытия: ");
                string? arr = Console.ReadLine();
                Console.Write("\nВведите тип ВС: ");
                string? type = Console.ReadLine();
                Console.Clear();
                if (numb != null)
                    if (dep != null)
                        if (arr != null)
                            if (type != null)
                                Database.new_flight(numb, dep, arr, type);

                Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню админа");
                Console.ReadKey();
                menu();
                break;
            case 2: //УДАЛЕНИЕ РЕЙСА
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("id\t\tNumber\t\tDepature\t\tArrival\t\t\tAirplane");
                Console.ResetColor();
                Database.get_table("flight_number");
                Console.Write("\nВведите номер рейса, котрый требуется удалить(нажмите Enter, чтобы выйти): ");
                string? num_flight = Console.ReadLine();
                Database.delete_flight(num_flight);
                Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню админа");
                Console.ReadKey();
                menu();
                break;
            case 3: //GET FLIGHT
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("id\t\tNumber\t\tDepature\t\tArrival\t\t\tAirplane");
                Console.ResetColor();
                Database.get_table("flight_number");
                Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню админа");
                Console.ReadKey();
                menu();
                break;
            case 4: //BOOKING
                Console.Clear();
                Database.get_BOOK("booking");
                Console.WriteLine("Выберите:\n1 - Создать новое бронирование\n2 - Удалить бронирование\n3 - Информация о бронировании\n4 - Выход в меню админа");
                Console.ForegroundColor = ConsoleColor.Green;
                int sc = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                switch (sc)
                {
                    case 1:
                        Ticket.creat();
                        choice();
                        break;
                    case 2:
                        Console.Write("Введите номер брони, для удаления: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        string? book = Console.ReadLine();
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
                    case 3:
                        Console.Write("Введите номер брони: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string? bk = Console.ReadLine();
                        Console.ResetColor();
                        Console.Clear();
                        Database.get_book_string("booking", bk);
                        break;
                    case 4:
                        menu();
                        break;
                }
                Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню админа");
                Console.ReadKey();
                menu();
                break;
            case 5: //AIRPLANE
                Console.Clear();
                Console.WriteLine("Выберите:\n1 - Список ВС\n2 - Добавить ВС\n3 - Выход в меню админа");
                Console.ForegroundColor = ConsoleColor.Green;
                int pl = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                switch (pl)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Type\t\tSize\t\tQuantity\tPlaces");
                        Console.ResetColor();
                        Database.get_table("airplane");
                        Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню админа");
                        Console.ReadKey();
                        menu();
                        break;
                    case 2:
                        Airplane.Airplane.new_plane();
                        Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню админа");
                        Console.ReadKey();
                        menu();
                        break;
                    case 3:
                        menu();
                        break;
                }
                break;
            case 6: //EXIT
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
        Console.Write("Войдите в аккаунт администратора\n\nВведите логин: ");
        Console.ForegroundColor = ConsoleColor.Green;
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
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Логин или пароль неверный!");
            Console.ResetColor();
            Console.WriteLine("\n\nВведите:\n1 - повторить попытку\n2 - выйти в главное меню");
            Console.ForegroundColor = ConsoleColor.Green;
            int gd = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            switch (gd)
            {
                case 1:
                    choice();
                    break;
                case 2:
                    Main.menu();
                    break;
                default:
                    Console.WriteLine("Вы дурак?");
                    break;
            }
        }
    }
}