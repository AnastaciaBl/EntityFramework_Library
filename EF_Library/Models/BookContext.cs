using System.Data.Entity;

namespace EF_Library
{
    class BookContext:DbContext
    {
        public BookContext():base("DbConnection") { }

        public DbSet<Book> Books { get; set; }
    }
}
