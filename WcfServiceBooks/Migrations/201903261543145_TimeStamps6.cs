namespace WcfServiceBooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeStamps6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Pic", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Pic");
        }
    }
}
