namespace Project_2;

public class Main
{
    public static void menu()
    {
        Console.Clear();
        Console.WriteLine("" +
                          "                                                                                                                                       =");
        Console.WriteLine("\n░█████╗░███████╗██████╗░░█████╗░██████╗░░█████╗░░█████╗░██╗░░██╗██╗███╗░░██╗░██████╗░\n" +
                          "██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░██╔╝██║████╗░██║██╔════╝░\n" +
                          "███████║█████╗░░██████╔╝██║░░██║██████╦╝██║░░██║██║░░██║█████═╝░██║██╔██╗██║██║░░██╗░\n" +
                          "██╔══██║██╔══╝░░██╔══██╗██║░░██║██╔══██╗██║░░██║██║░░██║██╔═██╗░██║██║╚████║██║░░╚██╗\n" +
                          "██║░░██║███████╗██║░░██║╚█████╔╝██████╦╝╚█████╔╝╚█████╔╝██║░╚██╗██║██║░╚███║╚██████╔╝\n" +
                          "╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═════╝░░╚════╝░░╚════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝░╚═════╝░\n");
        Console.Write("\n\nВыберите:\n1 - Меню регистрации на рейс\n2 - Меню покупки билета\n3 - Информация о бронировании\n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("4 - Админ панель\n");
        Console.ResetColor();
        // int fr = Convert.ToInt32(Console.ReadLine());
        
        ConsoleKeyInfo moveKey = Console.ReadKey();
        switch (moveKey.Key)
        {
            case ConsoleKey.D1:
                Registration.choice(); // exit
                break;
            case ConsoleKey.D2:
                Ticket.creat(); // exit
                break;
            case ConsoleKey.D3:
                Inf_booking.get(); //
                break;
            case ConsoleKey.D4:
                Admin.choice();
                break;
            // case ConsoleKey.D5:
            //     Console.WriteLine("Введите номер рейса: ");
            //     Console.ForegroundColor = ConsoleColor.Red;
            //     string? flight = Console.ReadLine();
            //     Console.ResetColor();
            //     Database.get_string("flight_number", "num", flight, 4);
            //     break;
            default:
                menu();
                break;
                
        }
    }
}