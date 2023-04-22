using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using System.IO;

namespace Project_2
{
    public static class Database
    {
        ///Creat NEW flight
        public static void new_flight(string numb, string dep, string arr, string airpl)
        {
            using (var connection = new SqliteConnection("Data Source=database.sqlite3"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText =
                    $"INSERT INTO flight_number (num, depature, arrival, airplane) VALUES ('{numb}', '{dep}', '{arr}', '{airpl}')";
                int number = command.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nВ таблицу flight_number добавлен рейс: {numb}");
                Console.ResetColor();
            }
        }

        ///Delete flight
        public static void delete_flight(string numb)
        {
            string sqlExpression = $"DELETE  FROM flight_number WHERE num='{numb}'";
            using (var connection = new SqliteConnection("Data Source=database.sqlite3"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nРейс {numb} удалён");
                Console.ResetColor();
            }
        }

        public static void get_string()
        {
            string connectionString = "Data Source=database.sqlite3";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand("SELECT * FROM flight_number", connection);
                SqliteDataReader reader = command.ExecuteReader();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("id\t\tNumber\t\tDepature\t\tArrival\t\t\tAirplane");
                Console.ResetColor();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t\t");
                    }
                    Console.WriteLine();
                }
                reader.Close();
            }
        }



        ///Creat NEW booking
        public static void new_booking(string number_booking, string number_flight, int numb_of_pax, string pax)
        {
            using (var connection = new SqliteConnection("Data Source=database.sqlite3"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO booking (book_num, fl_num, n_pax, pax) VALUES ('{number_booking}', '{number_flight}', '{numb_of_pax}', '{pax}')";
                int number = command.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nИнформация о вашем бронировании(сохранено в book.txt)\n");
                Console.ResetColor();
                string info = $"\nКод бронирования: {number_booking}\n" +
                              $"Количество пассажиров: {numb_of_pax}\n" +
                              $"Пассажиры: {pax}\n" +
                              $"Рейс: {number_flight}\n" +
                              $"Питание: предоставляется\n" +
                              $"Класс: Эконом\n" +
                              $"Статус: подтвержден\n\n" +
                              $"Стоимость заказа: {14400 * numb_of_pax}₽\n";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(info);
                Console.ResetColor();
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter($"./{number_booking}.txt");
                //Write a line of text
                sw.WriteLine(info);
                //Close the file
                sw.Close();
                
            }
        }
        
    }
}