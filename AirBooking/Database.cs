using Microsoft.Data.Sqlite;
using System.Data;

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
                command.CommandText = $"INSERT INTO flight_number (num, depature, arrival, airplane) VALUES ('{numb}', '{dep}', '{arr}', '{airpl}')";
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

        //Get string TABLE
        public static void get_table(string table)
        {
            string connectionString = "Data Source=database.sqlite3";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand($"SELECT * FROM {table}", connection);
                SqliteDataReader reader = command.ExecuteReader();
                // Console.ForegroundColor = ConsoleColor.Yellow;
                // Console.WriteLine("id\t\tNumber\t\tDepature\t\tArrival\t\t\tAirplane");
                // Console.ResetColor();
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

        //Get string BOOK
        public static void get_BOOK(string table)
        {
            string connectionString = "Data Source=database.sqlite3";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand($"SELECT * FROM {table}", connection);
                SqliteDataReader reader = command.ExecuteReader();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("id\t\tNumber\t\tFlight\t\tNumb\t\tPAX");
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

        //Get privat string BOOK
        public static void get_book_string(string table, string colomn)
        {
            string connectionString = "Data Source=database.sqlite3";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand($"SELECT * FROM {table} WHERE book_num='{colomn}'", connection);
                SqliteDataReader reader = command.ExecuteReader();
                string info = "NULL";

                string flight = get_string("booking", "book_num", colomn, 2);
                string airplane = get_string("flight_number", "num", flight, 4);

                reader.Read();
                info = $"Код бронирования:\t\t{reader[1]}\n" + $"Количество пассажиров:\t\t{reader[3]}\n" + $"Пассажиры:\t\t\t{reader[4]}\n" + $"Рейс:\t\t\t\t{reader[2]}\n" + $"Тип ВС:\t\t\t\t{airplane}\n" + $"Питание:\t\t\tпредоставляется\n" + $"Класс:\t\t\t\tЭконом\n" + $"Статус:\t\t\t\tподтвержден\n\n" + $"Стоимость заказа:\t\t{14400 * Convert.ToInt64(reader[3])}₽\n";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(info);
                Console.ResetColor();
                reader.Close();
            }
        }

        //Get string 
        public static string? get_string(string table, string colomn, string find, int index)
        {
            string connectionString = "Data Source=database.sqlite3";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand($"SELECT * FROM {table} WHERE {colomn}='{find}'", connection);
                SqliteDataReader reader = command.ExecuteReader();
                string info = "NULL";
                reader.Read();
                return Convert.ToString(reader[Convert.ToInt32(index)]);
            }
        }

        ///Delete
        public static void delete(string table, string colomn, string find_string)
        {
            string sqlExpression = $"DELETE  FROM {table} WHERE {colomn}='{find_string}'";
            using (var connection = new SqliteConnection("Data Source=database.sqlite3"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
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

                string flight = get_string("booking", "book_num", number_booking, 2);
                string airplane = get_string("flight_number", "num", flight, 4);

                string info = $"\nКод бронирования:\t\t{number_booking}\n" + $"Количество пассажиров:\t\t{numb_of_pax}\n" + $"Пассажиры:\t\t\t{pax}\n" + $"Рейс:\t\t\t\t{number_flight}\n" + $"Тип ВС:\t\t\t\t{airplane}\n" + $"Питание:\t\t\tпредоставляется\n" + $"Класс:\t\t\t\tЭконом\n" + $"Статус:\t\t\t\tподтвержден\n\n" + $"Стоимость заказа:\t\t{14400 * numb_of_pax}₽\n";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(info);
                Console.ResetColor();

                StreamWriter sw = new StreamWriter($"./{number_booking}.txt");
                sw.WriteLine(info);
                sw.Close();

            }
        }

        //Create NEW plane
        public static void new_plane(string type, string size, string quatity, string places)
        {
            using (var connection = new SqliteConnection("Data Source=database.sqlite3"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO airplane (plain_type, plain_size, quantity, places) VALUES ('{type}', '{size}', '{quatity}', '{places}')";
                int number = command.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nСоздан новый тип ВС: {type}\n" + $"\nРазмер: {size}" + $"\nКоличество: {quatity}" + $"\nПосадочных мест: {places}");
                Console.ResetColor();
            }
        }

        //Update 
        public static void update(string table, string find_colomn, string find, string newcolomn, string newvalue)
        {
            string sqlExpression = $"UPDATE {table} SET {newcolomn}='{newvalue}' WHERE {find_colomn} ='{find}'";
            using (var connection = new SqliteConnection("Data Source=database.sqlite3"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
            }
        }
    }
}