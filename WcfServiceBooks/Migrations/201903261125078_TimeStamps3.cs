namespace WcfServiceBooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeStamps3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Picture", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Picture");
        }
    }
}
