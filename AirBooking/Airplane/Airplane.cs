namespace Project_2.Airplane;

public class Airplane
{
    public static string[] Hletter = new string[13] {" ", "A", "B", "C", " ", "D", "E", "F", "G", " ", "H", "J", "K" };
    
    public static string[] Mletter = new string[8] { " ", "A", "B", "C", " ", "D", "E", "F"};

    public static void print_salon(string[,] salon, string book_number)
    {
        Console.Clear();
        Console.WriteLine("Регистрация: ");
        Database.get_book_string("booking", book_number);
        
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("■ - место свободно; ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("□ - место занято; ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("■ - Ваше место.\n");
        Console.ResetColor();

        string flight_number = Database.get_string("booking", "book_num", book_number, 2);
        string airplane = Database.get_string("flight_number", "num", flight_number, 4);
        string name_plane = Database.get_string("airplane", "plain_type", airplane, 4);

        int width = name_plane.Length/2;

        for (int i = 0; i < salon.GetLength(1) - width; i++)
        {
            Console.Write("  ");
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{name_plane}\n");
        Console.ResetColor();
        
        Console.Write(" ");
        for (int i = 0; i < salon.GetLength(0); i++)
        {
            for (int j = 0; j < salon.GetLength(1); j++)
            {
                if (salon[i, j] == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(" ■  ");
                    Console.ResetColor();
                }
                else if (salon[i, j] == "0")
                {
                    Console.Write("   ");
                }
                else if (salon[i, j] == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" □  ");
                    Console.ResetColor();
                }
                else if (salon[i, j] == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" ■  ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write($" {salon[i, j]} ");
                }

            }

            Console.WriteLine();
        }
    }
    public static void new_plane()
    {
        Console.Clear();
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nСистема создания нового типа воздушного судна");
        Console.ResetColor();
        
        Console.WriteLine("\nТаблица существующих: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Type\t\tSize\t\tQuantity\tPlaces\t\tName");
        Console.ResetColor();
        Database.get_table("airplane", 5);
        
        Console.WriteLine("Для выхода введите '/exit'");
        
        Console.Write("\nВведите тип нового ВС");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" (строго ICAO обозначение!): ");
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.Green;
        string? type = Console.ReadLine();
        Console.ResetColor();
        
        
        Console.Write("\nВведите название ВС: ");
        Console.ForegroundColor = ConsoleColor.Green;
        string? name = Console.ReadLine();
        Console.ResetColor();
        
        
        Console.Write("\nВведите размер вместимости");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" (L - light(DHC6), M - Medium(A320), H - Hight(A350)): ");
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.Green;
        string? size = Console.ReadLine();
        Console.ResetColor();
        
        Console.Write("\nВведите количество самолетов: ");
        
        Console.ForegroundColor = ConsoleColor.Green;
        string? quantity = Console.ReadLine();
        Console.ResetColor();
        
        Console.Write("\nВведите количество PAX: ");
        
        Console.ForegroundColor = ConsoleColor.Green;
        string? places = Console.ReadLine();
        Console.ResetColor();
        
        Console.Clear();
        Database.new_plane(type, size, quantity, places, name);
    }
    public static void salon(string size, string flight_num, string book_num)
    {
        if (size == "MEGA")
        {
            string[,] salon = new string[13, 60]
            {
                { " ", "|", "58", "57", "56", "55", "54", "53", "52", "51", "50", "49", "48", "47", "46", "45", "44", "43", "42", "41", " ", "39", "38", "37", "36", "35", "34", "33", "32", "31", "30", "29", "28", "27", "26", "25", "24", " ", "22", "21", "20", "19", "18", "17", "16", "15", "14", "13", "12", "11", "10", "09", "08", "07", "06", "05", "04", "03", "02", "01" },
                { "A", "|", "1", "1", "2", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1" },
                { "B", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "2", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1" },
                { "C", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1" },
                { " ", "|", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                { "D", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1" },
                { "E", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1" },
                { "F", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1" },
                { "G", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1" },
                { " ", "|", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                { "H", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1" },
                { "J", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1" },
                { "K", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1" }, 
            };
            ///ПРОВЕРКА НА УЖЕ РАНДОМИЗИРОВАННЫХ РАХ
            if (Database.get_string("flight_number", "num", flight_num, 5) != "")
            {
                string? arr = Database.get_string("flight_number", "num", flight_num, 5);
                salon = Tool.StringToArray(arr);
            }
            else
            {
                Random rnd = new Random();
                int n = rnd.Next(80, 180);
                for (int i = 0; i < n; i++)
                {
                    int fst = rnd.Next(1, 13);
                    int sec = rnd.Next(2, 35);
                    if (salon[fst, sec] != "0")
                    {
                        salon[fst, sec] = "2";
                    }
                    else
                    {
                        n++;
                    }
                }
                //СОХРАНЕНИЕ NEW СОСТОЯНИЯ
                Database.update("flight_number", "num", flight_num, "red_places", Tool.ArrayToString(salon));
                Console.WriteLine("SAVE!");
            }
            
            print_salon(salon, book_num);

            if (Database.get_string("booking", "book_num", book_num, 6) == Database.get_string("booking", "book_num", book_num, 3))
            {
                string? sts = Database.get_string("booking", "book_num", book_num, 5);
                salon = Tool.StringToArray(sts);
            }
            else
            {
                int pax = Convert.ToInt32(Database.get_string("booking", "book_num", book_num, 3));
                int i = 0;
                for (i = 0; i < pax; i++)
                {
                    Console.Write($"\nВыберите место для пассажира: {i+1}\n\nРяд(цифра): ");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Место(буква): ");
                    
                    string keyy = Console.ReadLine();
                    int wrd = 6;
                    for (int j = 0; j < salon.GetLength(0); j++)
                    {
                        if (keyy == Hletter[j])
                        {
                            wrd = j;
                            break;
                        }
                    }
                    salon[wrd, row + 1] = "3";
                    Console.Clear();
                    print_salon(salon, book_num);
                }

                Database.update("booking", "book_num", book_num, "place", Tool.ArrayToString(salon));
                Database.update("booking", "book_num", book_num, "chk", Convert.ToString(i));
            }
            Console.Clear();

            print_salon(salon, book_num);
            
            Console.WriteLine("\n");
            
            int width = 10;
            for (int i = 0; i < salon.GetLength(1) - width; i++)
            {
                Console.Write("  ");
            }
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Вы успешно зарегистрированы!");
            Console.ResetColor();
            Console.WriteLine();
        }
        else if (size == "M")
        {
            string[,] salon = new string[8, 35]
            {
                { " ", "|", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", " ", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33" },
                { "A", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "B", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "C", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { " ", "|", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                { "D", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "E", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "F", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
            };
            
            ///ПРОВЕРКА НА УЖЕ РАНДОМИЗИРОВАННЫХ РАХ
            if (Database.get_string("flight_number", "num", flight_num, 5) != "")
            {
                string? arr = Database.get_string("flight_number", "num", flight_num, 5);
                salon = Tool.StringToArray(arr);
            }
            else
            {
                Random rnd = new Random();
                int n = rnd.Next(35, 115);
                for (int i = 0; i < n; i++)
                {
                    int fst = rnd.Next(1, 8);
                    int sec = rnd.Next(2, 35);
                    if (salon[fst, sec] != "0")
                    {
                        salon[fst, sec] = "2";
                    }
                    else
                    {
                        n++;
                    }
                }
                //СОХРАНЕНИЕ NEW СОСТОЯНИЯ
                Database.update("flight_number", "num", flight_num, "red_places", Tool.ArrayToString(salon));
                Console.WriteLine("SAVE!");
            }
            
            print_salon(salon, book_num);

            if (Database.get_string("booking", "book_num", book_num, 6) == Database.get_string("booking", "book_num", book_num, 3))
            {
                string? sts = Database.get_string("booking", "book_num", book_num, 5);
                salon = Tool.StringToArray(sts);
            }
            else
            {
                //Для регистрация в мэин базу
                string? main_salon = Database.get_string("flight_number", "num", flight_num, 5);
                string[,] main_arr_salon = new string[8, 35];
                main_arr_salon = Tool.StringToArray(main_salon);

                int pax = Convert.ToInt32(Database.get_string("booking", "book_num", book_num, 3));
                int i;
                for (i = 0; i < pax; i++)
                {
                    Console.Write($"\nВыберите место для пассажира: {i+1}\n\nРяд(цифра): ");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Место(буква): ");
                    string keyy = Console.ReadLine();
                    int wrd = 6;
                    for (int j = 0; j < salon.GetLength(0); j++)
                    {
                        if (keyy == Mletter[j])
                        {
                            wrd = j;
                            break;
                        }
                    }
                    salon[wrd, row + 1] = "3";
                    main_arr_salon[wrd, row + 1] = "2";
                    Console.Clear();
                    print_salon(salon, book_num);
                }

                Database.update("flight_number", "num", flight_num, "red_places", Tool.ArrayToString(main_arr_salon)); // Сохранение в мэин базу свободных мест
                Database.update("booking", "book_num", book_num, "place", Tool.ArrayToString(salon));
                Database.update("booking", "book_num", book_num, "chk", Convert.ToString(i));
            }
            Console.Clear();

            print_salon(salon, book_num);
            
            Console.WriteLine("\n");
            
            int width = 10;
            for (int i = 0; i < salon.GetLength(1) - width; i++)
            {
                Console.Write("  ");
            }
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Вы успешно зарегистрированы!");
            Console.ResetColor();
            Console.WriteLine();
        }
        
        else if (size == "H")
        {
            string[,] salon = new string[13, 35]
            {
                { " ", "|", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", " ", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33" },
                { "A", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "B", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "C", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { " ", "|", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                { "D", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "E", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "F", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "G", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { " ", "|", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                { "H", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "J", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "K", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
            };
            
            ///ПРОВЕРКА НА УЖЕ РАНДОМИЗИРОВАННЫХ РАХ
            if (Database.get_string("flight_number", "num", flight_num, 5) != "")
            {
                string? arr = Database.get_string("flight_number", "num", flight_num, 5);
                salon = Tool.StringToArray(arr);
            }
            else
            {
                Random rnd = new Random();
                int n = rnd.Next(80, 180);
                for (int i = 0; i < n; i++)
                {
                    int fst = rnd.Next(1, 13);
                    int sec = rnd.Next(2, 35);
                    if (salon[fst, sec] != "0")
                    {
                        salon[fst, sec] = "2";
                    }
                    else
                    {
                        n++;
                    }
                }
                //СОХРАНЕНИЕ NEW СОСТОЯНИЯ
                Database.update("flight_number", "num", flight_num, "red_places", Tool.ArrayToString(salon));
            }
            
            print_salon(salon, book_num);

            if (Database.get_string("booking", "book_num", book_num, 6) == Database.get_string("booking", "book_num", book_num, 3))
            {
                string? sts = Database.get_string("booking", "book_num", book_num, 5);
                salon = Tool.StringToArray(sts);
            }
            ////ENTERING PLACE
            else
            {
                //Для регистрация в мэин базу
                string? main_salon = Database.get_string("flight_number", "num", flight_num, 5);
                string[,] main_arr_salon = new string[13, 35];
                main_arr_salon = Tool.StringToArray(main_salon);
                
                int pax = Convert.ToInt32(Database.get_string("booking", "book_num", book_num, 3));
                int i = 0;
                for (i = 0; i < pax; i++)
                {
                    Console.Write($"\nВыберите место для пассажира: {i+1}\n\nРяд(цифра): ");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Место(буква): ");
                    
                    string keyy = Console.ReadLine();
                    int wrd = 6;
                    for (int j = 0; j < salon.GetLength(0); j++)
                    {
                        if (keyy == Hletter[j])
                        {
                            wrd = j;
                            break;
                        }
                    }
                    salon[wrd, row + 1] = "3";
                    main_arr_salon[wrd, row + 1] = "2";
                    Console.Clear();
                    print_salon(salon, book_num);
                }

                // main_salon = Tool.ArrayToString(main_arr_salon);
                Database.update("flight_number", "num", flight_num, "red_places", Tool.ArrayToString(main_arr_salon)); // Сохранение в мэин базу свободных мест
                Database.update("booking", "book_num", book_num, "place", Tool.ArrayToString(salon));
                Database.update("booking", "book_num", book_num, "chk", Convert.ToString(i));
            }
            Console.Clear();

            print_salon(salon, book_num);
            
            Console.WriteLine("\n");
            
            int width = 10;
            for (int i = 0; i < salon.GetLength(1) - width; i++)
            {
                Console.Write("  ");
            }
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Вы успешно зарегистрированы!");
            Console.ResetColor();
            Console.WriteLine();
        }
        
        else
        {
            string[,] salon = new string[8, 35]
            {
                { " ", "|", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", " ", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33" },
                { "A", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "B", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "C", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { " ", "|", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                { "D", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "E", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                { "F", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
            };
            
            ///ПРОВЕРКА НА УЖЕ РАНДОМИЗИРОВАННЫХ РАХ
            if (Database.get_string("flight_number", "num", flight_num, 5) != "")
            {
                string? arr = Database.get_string("flight_number", "num", flight_num, 5);
                salon = Tool.StringToArray(arr);
            }
            else
            {
                Random rnd = new Random();
                int n = rnd.Next(35, 115);
                for (int i = 0; i < n; i++)
                {
                    int fst = rnd.Next(1, 8);
                    int sec = rnd.Next(2, 35);
                    if (salon[fst, sec] != "0")
                    {
                        salon[fst, sec] = "2";
                    }
                    else
                    {
                        n++;
                    }
                }
                //СОХРАНЕНИЕ NEW СОСТОЯНИЯ
                Database.update("flight_number", "num", flight_num, "red_places", Tool.ArrayToString(salon));
            }
            
            print_salon(salon, book_num);

            if (Database.get_string("booking", "book_num", book_num, 6) == Database.get_string("booking", "book_num", book_num, 3))
            {
                string? sts = Database.get_string("booking", "book_num", book_num, 5);
                salon = Tool.StringToArray(sts);
            }
            else
            {
                //Для регистрация в мэин базу
                string? main_salon = Database.get_string("flight_number", "num", flight_num, 5);
                string[,] main_arr_salon = new string[8, 35];
                main_arr_salon = Tool.StringToArray(main_salon);

                int pax = Convert.ToInt32(Database.get_string("booking", "book_num", book_num, 3));
                int i;
                for (i = 0; i < pax; i++)
                {
                    Console.Write($"\nВыберите место для пассажира: {i+1}\n\nРяд(цифра): ");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Место(буква): ");
                    string keyy = Console.ReadLine();
                    int wrd = 6;
                    for (int j = 0; j < salon.GetLength(0); j++)
                    {
                        if (keyy == Mletter[j])
                        {
                            wrd = j;
                            break;
                        }
                    }
                    salon[wrd, row + 1] = "3";
                    main_arr_salon[wrd, row + 1] = "2";
                    Console.Clear();
                    print_salon(salon, book_num);
                }

                Database.update("flight_number", "num", flight_num, "red_places", Tool.ArrayToString(main_arr_salon)); // Сохранение в мэин базу свободных мест
                Database.update("booking", "book_num", book_num, "place", Tool.ArrayToString(salon));
                Database.update("booking", "book_num", book_num, "chk", Convert.ToString(i));
            }
            Console.Clear();

            print_salon(salon, book_num);
            
            Console.WriteLine("\n");
            
            int width = 10;
            for (int i = 0; i < salon.GetLength(1) - width; i++)
            {
                Console.Write("  ");
            }
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Вы успешно зарегистрированы!");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}