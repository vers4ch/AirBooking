namespace Project_2;

public class Inf_booking
{
    public static void get()
    {
        Console.Clear();
        Console.Write("\nВведите номер брони: ");
        Console.ForegroundColor = ConsoleColor.Green;
        string? bk = Console.ReadLine();
        Console.ResetColor();
        if (bk.Length == 6)
        {
            Console.Clear();
            Console.WriteLine("\nИнформация о бронировании: \n");
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
            get();
        }
    }
}