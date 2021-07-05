namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOneToOneRelationshipsForCountryAndRest : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.HealthcareAndSciences", "CountryName");
            CreateIndex("dbo.PoliticsAndEconomics", "CountryName");
            CreateIndex("dbo.QualityOfLives", "CountryName");
            CreateIndex("dbo.Taxes", "CountryName");
            AddForeignKey("dbo.HealthcareAndSciences", "CountryName", "dbo.Countries", "CountryName");
            AddForeignKey("dbo.PoliticsAndEconomics", "CountryName", "dbo.Countries", "CountryName");
            AddForeignKey("dbo.QualityOfLives", "CountryName", "dbo.Countries", "CountryName");
            AddForeignKey("dbo.Taxes", "CountryName", "dbo.Countries", "CountryName");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Taxes", "CountryName", "dbo.Countries");
            DropForeignKey("dbo.QualityOfLives", "CountryName", "dbo.Countries");
            DropForeignKey("dbo.PoliticsAndEconomics", "CountryName", "dbo.Countries");
            DropForeignKey("dbo.HealthcareAndSciences", "CountryName", "dbo.Countries");
            DropIndex("dbo.Taxes", new[] { "CountryName" });
            DropIndex("dbo.QualityOfLives", new[] { "CountryName" });
            DropIndex("dbo.PoliticsAndEconomics", new[] { "CountryName" });
            DropIndex("dbo.HealthcareAndSciences", new[] { "CountryName" });
        }
    }
}
