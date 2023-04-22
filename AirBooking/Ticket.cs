namespace Project_2;

public class Ticket
{
    static string GenerateNumberBook()
    {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string digits = "0123456789";
        string randomWord = new string(Enumerable.Repeat(chars, 2)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        randomWord += digits[random.Next(digits.Length)];
        randomWord += new string(Enumerable.Repeat(chars, 3)
            .Select(s => s[random.Next(s.Length)]).ToArray()).ToUpper();
        return randomWord;
    }
    
    public static void creat()
    {
        string pax = "NULL";
        Console.Clear();
        Console.WriteLine("\nМеню покупки билета\n");
        
        Database.get_string();
        
        Console.Write("\nВведите номер интересующего Вас рейса: ");
        string numb = Console.ReadLine();
        
        Console.Write("\nСтоимость билета: 14 400₽\n\nВведите количество пассажиров: ");
        int numb_pax = Convert.ToInt32(Console.ReadLine());
        if (numb_pax < 1)
        {
            Console.WriteLine("Минимум пассажиров: 1");
            creat();
        }
        else if (numb_pax == 1)
        {
            Console.Write("\nВведите ФИО пассажира(Латиницей): ");
            pax = Console.ReadLine();
        }
        else
        {
            Console.Write("\nВведите ФИО пассажиров (через запятую, латиницей): ");
            pax = Console.ReadLine();
        }
        Console.Clear();
        string randomWord = GenerateNumberBook();
        Database.new_booking(randomWord, numb, numb_pax, pax);
        Console.WriteLine("Нажмите любую клавишу, чтобы выйти в главное меню.");
        Console.ReadKey();
        Main.menu();
    }
}