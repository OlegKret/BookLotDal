namespace WcfServiceBooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeStamps4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Picture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Picture", c => c.String(nullable: false, maxLength: 250));
        }
    }
}
