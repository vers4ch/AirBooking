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
        Console.Write("\n\nВыберите:\n1 - Меню регистрации на рейс\n2 - Меню покупки билета\n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("3 - Админ панель\n");
        Console.ResetColor();
        int fr = Convert.ToInt32(Console.ReadLine());
        switch (fr)
        {
            case 1:
                Console.WriteLine("Еще не реализовано!");
                break;
            case 2:
                Ticket.creat();
                break;
            case 3:
                Admin.choice();
                break;
                
        }
    }
}