using System.Data.Entity;

namespace EF_Library
{
    class OrderContext:DbContext
    {
        public OrderContext():base("DbConnection") { }

        public DbSet<Order> Orders { get; set; }
    }
}
