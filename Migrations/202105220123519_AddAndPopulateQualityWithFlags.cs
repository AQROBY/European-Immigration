namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAndPopulateQualityWithFlags : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QualityOfLives", "Flag", c => c.String());

            Sql("UPDATE QualityOfLives SET Flag = '\\images\\austria.png' WHERE CountryName = 'Austria'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\belgium.png' WHERE CountryName = 'Belgium'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\bulgaria.png' WHERE CountryName = 'Bulgaria'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\cyprus.png' WHERE CountryName = 'Cyprus'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\czech.png' WHERE CountryName = 'Czech Republic'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\denmark.png' WHERE CountryName = 'Denmark'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\estonia.png' WHERE CountryName = 'Estonia'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\finland.png' WHERE CountryName = 'Finland'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\france.png' WHERE CountryName = 'France'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\germany.png' WHERE CountryName = 'Germany'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\greece.png' WHERE CountryName = 'Greece'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\hungary.png' WHERE CountryName = 'Hungary'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\ireland.png' WHERE CountryName = 'Ireland'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\italy.png' WHERE CountryName = 'Italy'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\latvia.png' WHERE CountryName = 'Latvia'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\lithuania.png' WHERE CountryName = 'Lithuania'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\luxembourg.png' WHERE CountryName = 'Luxembourg'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\malta.png' WHERE CountryName = 'Malta'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\netherlands.png' WHERE CountryName = 'Netherlands'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\poland.png' WHERE CountryName = 'Poland'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\portugal.png' WHERE CountryName = 'Portugal'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\romania.png' WHERE CountryName = 'Romania'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\slovakia.png' WHERE CountryName = 'Slovakia'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\slovenia.png' WHERE CountryName = 'Slovenia'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\spain.png' WHERE CountryName = 'Spain'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\sweden.png' WHERE CountryName = 'Sweden'");
            Sql("UPDATE QualityOfLives SET Flag = '\\images\\uk.png' WHERE CountryName = 'United Kingdom'");
        }
        
        public override void Down()
        {
            DropColumn("dbo.QualityOfLives", "Flag");
        }
    }
}
