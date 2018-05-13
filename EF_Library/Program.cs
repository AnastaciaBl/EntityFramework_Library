using System;

namespace EF_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            AddBook(new Book("1984", "George Orwell", "novel-dystopia"));
            AddClient(new Client("Vasya Petrov", "0972153457", "AO012584"));
            AddClient(new Client("Kolya Savushkin", "0972374581", "AO231854"));
            AddOrder(new Order(1, 2, 7));
            Console.Read();
        }

        private static void AddBook(Book book)
        {
            using (BookContext db = new BookContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
                Console.WriteLine("Книга {0} успешно добавлена.",book.Title);
            }
        }

        private static void AddClient(Client client)
        {
            using (ClientContext db = new ClientContext())
            {
                db.Clients.Add(client);
                db.SaveChanges();
                Console.WriteLine("Клиент {0} успешно добавлена.", client.FullName);
            }
        }

        private static void AddOrder(Order order)
        {
            using (OrderContext db = new OrderContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
                Console.WriteLine("Заказ #{0} успешно добавлен.", order.Id);
            }
        }
    }
}
