namespace WcfServiceBooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeStamps8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Pic", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Pic");
        }
    }
}
