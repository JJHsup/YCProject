namespace YCwebTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Password = c.String(nullable: false),
                        Cofirmpasswordforreset = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
