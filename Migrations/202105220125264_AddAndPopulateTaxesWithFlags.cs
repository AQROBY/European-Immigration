namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAndPopulateTaxesWithFlags : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Taxes", "Flag", c => c.String());

            Sql("UPDATE Taxes SET Flag = '\\images\\austria.png' WHERE CountryName = 'Austria'");
            Sql("UPDATE Taxes SET Flag = '\\images\\belgium.png' WHERE CountryName = 'Belgium'");
            Sql("UPDATE Taxes SET Flag = '\\images\\bulgaria.png' WHERE CountryName = 'Bulgaria'");
            Sql("UPDATE Taxes SET Flag = '\\images\\cyprus.png' WHERE CountryName = 'Cyprus'");
            Sql("UPDATE Taxes SET Flag = '\\images\\czech.png' WHERE CountryName = 'Czech Republic'");
            Sql("UPDATE Taxes SET Flag = '\\images\\denmark.png' WHERE CountryName = 'Denmark'");
            Sql("UPDATE Taxes SET Flag = '\\images\\estonia.png' WHERE CountryName = 'Estonia'");
            Sql("UPDATE Taxes SET Flag = '\\images\\finland.png' WHERE CountryName = 'Finland'");
            Sql("UPDATE Taxes SET Flag = '\\images\\france.png' WHERE CountryName = 'France'");
            Sql("UPDATE Taxes SET Flag = '\\images\\germany.png' WHERE CountryName = 'Germany'");
            Sql("UPDATE Taxes SET Flag = '\\images\\greece.png' WHERE CountryName = 'Greece'");
            Sql("UPDATE Taxes SET Flag = '\\images\\hungary.png' WHERE CountryName = 'Hungary'");
            Sql("UPDATE Taxes SET Flag = '\\images\\ireland.png' WHERE CountryName = 'Ireland'");
            Sql("UPDATE Taxes SET Flag = '\\images\\italy.png' WHERE CountryName = 'Italy'");
            Sql("UPDATE Taxes SET Flag = '\\images\\latvia.png' WHERE CountryName = 'Latvia'");
            Sql("UPDATE Taxes SET Flag = '\\images\\lithuania.png' WHERE CountryName = 'Lithuania'");
            Sql("UPDATE Taxes SET Flag = '\\images\\luxembourg.png' WHERE CountryName = 'Luxembourg'");
            Sql("UPDATE Taxes SET Flag = '\\images\\malta.png' WHERE CountryName = 'Malta'");
            Sql("UPDATE Taxes SET Flag = '\\images\\netherlands.png' WHERE CountryName = 'Netherlands'");
            Sql("UPDATE Taxes SET Flag = '\\images\\poland.png' WHERE CountryName = 'Poland'");
            Sql("UPDATE Taxes SET Flag = '\\images\\portugal.png' WHERE CountryName = 'Portugal'");
            Sql("UPDATE Taxes SET Flag = '\\images\\romania.png' WHERE CountryName = 'Romania'");
            Sql("UPDATE Taxes SET Flag = '\\images\\slovakia.png' WHERE CountryName = 'Slovakia'");
            Sql("UPDATE Taxes SET Flag = '\\images\\slovenia.png' WHERE CountryName = 'Slovenia'");
            Sql("UPDATE Taxes SET Flag = '\\images\\spain.png' WHERE CountryName = 'Spain'");
            Sql("UPDATE Taxes SET Flag = '\\images\\sweden.png' WHERE CountryName = 'Sweden'");
            Sql("UPDATE Taxes SET Flag = '\\images\\uk.png' WHERE CountryName = 'United Kingdom'");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Taxes", "Flag");
        }
    }
}
