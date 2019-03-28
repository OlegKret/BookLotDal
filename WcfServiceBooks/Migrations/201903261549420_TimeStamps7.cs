namespace WcfServiceBooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeStamps7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Pic");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Pic", c => c.String(nullable: false, maxLength: 150));
        }
    }
}
