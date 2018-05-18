using System.Data.Entity;

namespace EF_Library
{
    class LibraryContext: DbContext
    {
        public LibraryContext():base("DbConnection") { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
