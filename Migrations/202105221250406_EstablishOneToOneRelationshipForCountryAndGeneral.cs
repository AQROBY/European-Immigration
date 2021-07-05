namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EstablishOneToOneRelationshipForCountryAndGeneral : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.GeneralDatas", "CountryName");
            AddForeignKey("dbo.GeneralDatas", "CountryName", "dbo.Countries", "CountryName");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GeneralDatas", "CountryName", "dbo.Countries");
            DropIndex("dbo.GeneralDatas", new[] { "CountryName" });
        }
    }
}
