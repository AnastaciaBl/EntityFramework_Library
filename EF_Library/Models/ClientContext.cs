using System.Data.Entity;

namespace EF_Library
{
    class ClientContext:DbContext
    {
        public ClientContext():base("DbConnection") { }

        public DbSet<Client> Clients { get; set; }
    }
}
