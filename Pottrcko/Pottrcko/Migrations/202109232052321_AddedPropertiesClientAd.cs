namespace Pottrcko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPropertiesClientAd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "City", c => c.String(nullable: false));
            AddColumn("dbo.Clients", "Bank", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "Bank");
            DropColumn("dbo.Clients", "City");
        }
    }
}
