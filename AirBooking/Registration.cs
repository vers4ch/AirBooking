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