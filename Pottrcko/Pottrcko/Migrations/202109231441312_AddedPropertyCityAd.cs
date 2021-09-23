namespace Pottrcko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPropertyCityAd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ads", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ads", "City");
        }
    }
}
