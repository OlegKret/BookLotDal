namespace WcfServiceBooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeStamps1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "role", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "role");
        }
    }
}
