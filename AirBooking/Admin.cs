namespace Project_2;

public class Admin
{
    public static void menu()
    {
        Console.Clear();
        Console.WriteLine("Выберите:\n1 - Создать новый рейс\n2 - Удалить рейс\n3 - Список существующих рейсов\n4 - Бронирования\n5 - Выход в главное меню");
        int ch = Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
            // СОЗДАНИЕ РЕЙСА
            case 1:
                Console.Clear();
                Database.get_string_flight("flight_number");
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

                Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить");
                Console.ReadKey();
                menu();
                break;
            ///УДАЛЕНИЕ РЕЙСА
            case 2:
                Console.Clear();
                Database.get_string_flight("flight_number");
                Console.Write("\nВведите номер рейса, котрый требуется удалить(нажмите Enter, чтобы выйти): ");
                string? num_flight = Console.ReadLine();
                Database.delete_flight(num_flight);
                Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить");
                Console.ReadKey();
                menu();
                break;
            case 3:
                Console.Clear();
                Database.get_string_flight("flight_number");
                Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить");
                Console.ReadKey();
                menu();
                break;
            case 4:
                Console.Clear();
                Database.get_BOOK("booking");
                Console.WriteLine("Выберите:\n1 - Создать новое бронирование\n2 - Удалить бронирование\n3 - Информация о бронировании\n4 - Выход в меню админа");
                int sc = Convert.ToInt32(Console.ReadLine());
                switch (sc)
                {
                    case 1:
                        Ticket.creat();
                        choice();
                        break;
                    case 2:
                        Console.Write("Введите номер брони, для удаления: ");
                        string? book = Console.ReadLine();
                        Database.delete("booking", "book_num", book);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nБронирование {book} удалено.");
                        Console.ResetColor();
                        Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить");
                        Console.ReadKey();
                        menu();
                        break;
                    case 3:
                        Console.Write("Введите номер брони: ");
                        string? bk = Console.ReadLine();
                        Console.Clear();
                        Database.get_book_string("booking", bk);
                        break;
                    case 4:
                        menu();
                        break;
                }
                Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить");
                Console.ReadKey();
                menu();
                break;
            case 5:
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
        string? login = Console.ReadLine();
        Console.Write("Введите пароль: ");
        string? pass = Console.ReadLine();

        if (login == "admin" && pass == "admin")
        {
            menu();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Логин или пароль неверный!");
            Console.ResetColor();
            Console.WriteLine("\n\nВведите:\n1 - повторить попытку\n2 - выйти в главное меню");
            int gd = Convert.ToInt32(Console.ReadLine());
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