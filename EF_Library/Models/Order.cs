using System;
using System.ComponentModel.DataAnnotations;

namespace EF_Library
{
    class Order
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int Id_Book { get; set; }
        public int Id_Client { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Order() { }
        public Order(int book_id, int client_id, int amountOfUsingDays)
        {
            Id_Book = book_id;
            Id_Client = client_id;
            OrderDate = DateTime.Now;
            ReturnDate = OrderDate.AddDays(amountOfUsingDays);
        }
    }
}
