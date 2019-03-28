namespace WcfServiceBooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        AuthorId = c.Int(nullable: false),
                        PublisherId = c.Int(nullable: false),
                        Title = c.String(maxLength: 50),
                        ISBN = c.String(maxLength: 50),
                        Genre = c.String(maxLength: 50),
                        Type = c.String(maxLength: 50),
                        PublicationYear = c.String(maxLength: 50),
                        Price = c.Int(nullable: false),
                        Condition = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.BookId)
                .Index(t => t.Price, name: "IDX_Books_Price");
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        Timestamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.Quantity, name: "IDX_OrderItem_Quantity")
                .Index(t => t.Price, name: "IDX_OrderItem_Price");
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 50),
                        PhotoName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "BookId", "dbo.Books");
            DropIndex("dbo.OrderItems", "IDX_OrderItem_Price");
            DropIndex("dbo.OrderItems", "IDX_OrderItem_Quantity");
            DropIndex("dbo.OrderItems", new[] { "BookId" });
            DropIndex("dbo.Books", "IDX_Books_Price");
            DropTable("dbo.Users");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Books");
        }
    }
}
