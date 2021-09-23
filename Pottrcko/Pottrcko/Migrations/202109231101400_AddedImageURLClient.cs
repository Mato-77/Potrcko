namespace Pottrcko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImageURLClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "ImageURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "ImageURL");
        }
    }
}
