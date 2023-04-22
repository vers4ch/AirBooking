using Microsoft.Data.Sqlite;

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
                Console.WriteLine($"\nВ таблицу flight_number добавлен рейс: {numb}");
            }
        }
        
        ///Creat NEW booking
        public static void new_booking(string number_booking, string number_flight, int numb_of_pax)
        {
            using (var connection = new SqliteConnection("Data Source=database.sqlite3"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO booking (book_num, fl_num, n_pax) VALUES ('{number_booking}', '{number_flight}', '{numb_of_pax}')";
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"\nВ таблицу booking добавлено бронирование: {number_booking}");
            }
        }
        
        ///Enter PAX to book
        public static void pax_to_book(string number_booking, string pax)
        {
            using (var connection = new SqliteConnection("Data Source=database.sqlite3"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO booking (n_book, pax) VALUES ('{number_booking}', '{pax}')";
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"\nВ таблицу booking в бронирование {number_booking} добавлены пассажиры: {pax}");
            }
        }
        
    }
}