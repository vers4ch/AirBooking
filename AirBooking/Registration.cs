using Project_2.Airplane;

namespace Project_2;

public class Registration
{
    public static void choice()
    {
        Console.Clear();
        Console.Write("\nВведите номер брони: ");
        Console.ForegroundColor = ConsoleColor.Red;
        string? bk = Console.ReadLine();
        Console.ResetColor();
        if (bk.Length == 6)
        {
            Console.Clear();
            Database.get_book_string("booking", bk);
            string flight = Database.get_string("booking", "book_num", bk, 2);
            string typ = Database.get_string("flight_number", "num", flight, 4);
            
            Airplane.Airplane.type(typ);
            
            Console.WriteLine("\nНажмите любую клавишу, чтобы выйти в главное меню");
            Console.ReadKey();
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
    
}