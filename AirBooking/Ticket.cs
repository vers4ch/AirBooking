namespace Project_2;

public class Ticket
{
    static string GenerateNumberBook()
    {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string digits = "0123456789";
        string randomWord = new string(Enumerable.Repeat(chars, 2).Select(s => s[random.Next(s.Length)]).ToArray());
        randomWord += digits[random.Next(digits.Length)];
        randomWord += new string(Enumerable.Repeat(chars, 3).Select(s => s[random.Next(s.Length)]).ToArray()).ToUpper();
        return randomWord;
    }
    
    public static void creat()
    {
        string pax = "NULL";
        Console.Clear();
        Console.WriteLine("\nМеню покупки билета\n");
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("id\t\tNumber\t\tDepature\t\tArrival\t\t\tAirplane");
        Console.ResetColor();
        Database.get_table("flight_number", 5);
        
        Console.Write("\nВведите номер интересующего Вас рейса: ");
        Console.ForegroundColor = ConsoleColor.Green;
        string numb = Console.ReadLine();
        Console.ResetColor();
        
        Console.Write("\nСтоимость билета: 14 400₽\n\nВведите количество пассажиров: ");
        Console.ForegroundColor = ConsoleColor.Green;
        int numb_pax = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();
        if (numb_pax < 1)
        {
            Console.WriteLine("Минимум пассажиров: 1");
            creat();
        }
        else if (numb_pax == 1)
        {
            Console.Write("\nВведите ФИО пассажира(Латиницей): ");
            Console.ForegroundColor = ConsoleColor.Green;
            pax = Console.ReadLine();
            Console.ResetColor();
        }
        else
        {
            Console.Write("\nВведите ФИО пассажиров (через запятую, латиницей): ");
            Console.ForegroundColor = ConsoleColor.Green;
            pax = Console.ReadLine();
            Console.ResetColor();
        }
        Console.Clear();
        string randomWord = GenerateNumberBook();
        Database.new_booking(randomWord, numb, numb_pax, pax);
        Console.WriteLine("Нажмите любую клавишу, чтобы выйти в главное меню.");
        Console.ReadKey();
        Main.menu();
    }
}