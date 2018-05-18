namespace EF_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookMigrations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Price");
        }
    }
}
