namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeCountryPopulationNotRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Countries", "Population", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Countries", "Population", c => c.Int(nullable: false));
        }
    }
}
