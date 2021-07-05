namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAndPopulatePoliticsWithFlags : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PoliticsAndEconomics", "Flag", c => c.String());

            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\austria.png' WHERE CountryName = 'Austria'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\belgium.png' WHERE CountryName = 'Belgium'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\bulgaria.png' WHERE CountryName = 'Bulgaria'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\cyprus.png' WHERE CountryName = 'Cyprus'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\czech.png' WHERE CountryName = 'Czech Republic'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\denmark.png' WHERE CountryName = 'Denmark'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\estonia.png' WHERE CountryName = 'Estonia'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\finland.png' WHERE CountryName = 'Finland'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\france.png' WHERE CountryName = 'France'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\germany.png' WHERE CountryName = 'Germany'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\greece.png' WHERE CountryName = 'Greece'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\hungary.png' WHERE CountryName = 'Hungary'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\ireland.png' WHERE CountryName = 'Ireland'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\italy.png' WHERE CountryName = 'Italy'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\latvia.png' WHERE CountryName = 'Latvia'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\lithuania.png' WHERE CountryName = 'Lithuania'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\luxembourg.png' WHERE CountryName = 'Luxembourg'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\malta.png' WHERE CountryName = 'Malta'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\netherlands.png' WHERE CountryName = 'Netherlands'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\poland.png' WHERE CountryName = 'Poland'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\portugal.png' WHERE CountryName = 'Portugal'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\romania.png' WHERE CountryName = 'Romania'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\slovakia.png' WHERE CountryName = 'Slovakia'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\slovenia.png' WHERE CountryName = 'Slovenia'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\spain.png' WHERE CountryName = 'Spain'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\sweden.png' WHERE CountryName = 'Sweden'");
            Sql("UPDATE PoliticsAndEconomics SET Flag = '\\images\\uk.png' WHERE CountryName = 'United Kingdom'");
        }
        
        public override void Down()
        {
            DropColumn("dbo.PoliticsAndEconomics", "Flag");
        }
    }
}
