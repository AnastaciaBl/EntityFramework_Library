using System;

namespace EF_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            AddBook(new Book { Title = "1984", Author = "George Orwell", Topic = "novel-dystopia", Price = 2.0 });
            AddClient(new Client { FullName = "Vasya Petrov", Phone = "0972153457", Passport = "AO012584", RegistrationDate = DateTime.Now });
            AddClient(new Client { FullName = "Kolya Savushkin", Phone = "0972374581", Passport = "AO231854", RegistrationDate = DateTime.Now });
            AddOrder(new Order { Id_Book = 1, Id_Client = 2, OrderDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(7) });
            Console.Read();
        }

        private static void AddBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
                Console.WriteLine("Книга {0} успешно добавлена.",book.Title);
            }
        }

        private static void AddClient(Client client)
        {
            using (var db = new LibraryContext())
            {
                db.Clients.Add(client);
                db.SaveChanges();
                Console.WriteLine("Клиент {0} успешно добавлена.", client.FullName);
            }
        }

        private static void AddOrder(Order order)
        {
            using (var db = new LibraryContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
                Console.WriteLine("Заказ #{0} успешно добавлен.", order.Id);
            }
        }
    }
}
