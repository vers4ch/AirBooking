using Microsoft.Data.Sqlite;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ///АДМИН
            Console.WriteLine("Выберите:\n1 - Создать новый рейс\n2 - Удалить рейс\n3 - Изменить рейс");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                /// СОЗДАНИЕ РЕЙСА(АДМИН)
                case 1:
                    Console.Write("Введите номер рейса: ");
                    string? numb = Console.ReadLine();
                    
                    Console.Write("\nВведите аэропорт вылета: ");
                    string? dep = Console.ReadLine();
                    
                    Console.Write("\nВведите аэропорт прибытия: ");
                    string? arr = Console.ReadLine();
                    
                    Console.Write("\nВведите тип ВС: ");
                    string? type = Console.ReadLine();

                    if (numb != null)
                        if (dep != null)
                            if (arr != null)
                                if (type != null)
                                    Database.new_flight(numb, dep, arr, type);
                    break;
                
                
                ///УДАЛЕНИЕ РЕЙСА(АДМИН)
                case 2:
                    Console.WriteLine("Еще не реализовано!");
                    break;
                ///ИЗМЕНЕНИЕ РЕЙСА(АДМИН)
                case 3:
                    Console.WriteLine("Еще не реализовано!");
                    break;
                default:
                    Console.WriteLine("Еще не реализовано!");
                    break;
            }
        }

    }
    
}