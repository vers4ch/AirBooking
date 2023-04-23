namespace Project_2;

public class Main
{
    public static void menu()
    {
        Console.Clear();
        ///Начальное меню
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
        int fr = Convert.ToInt32(Console.ReadLine());
        switch (fr)
        {
            case 1:
                Registration.choice();
                break;
            case 2:
                Ticket.creat();
                break;
            case 3:
                Inf_booking.get();
                break;
            case 4:
                Admin.choice();
                break;
            case 5:
                Console.WriteLine("Введите номер рейса: ");
                Console.ForegroundColor = ConsoleColor.Red;
                string? flight = Console.ReadLine();
                Console.ResetColor();
                Database.get_string("flight_number", "num", flight, 4);
                break;
                
        }
    }
}