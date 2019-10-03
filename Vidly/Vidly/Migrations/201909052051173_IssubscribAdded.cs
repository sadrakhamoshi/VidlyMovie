namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IssubscribAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribeNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribeNewsletter");
        }
    }
}
