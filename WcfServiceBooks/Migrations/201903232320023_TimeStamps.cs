namespace WcfServiceBooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeStamps : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "PhotoName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "PhotoName", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
