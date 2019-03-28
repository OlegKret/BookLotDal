namespace WcfServiceBooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeStamps5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Image", c => c.Byte(nullable: false));
        }
    }
}
