namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAndPopulateGeneralDataWithFlags : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GeneralDatas", "Flag", c => c.String());

            Sql("UPDATE GeneralDatas SET Flag = 'images\\austria.png' WHERE CountryName = 'Austria'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\belgium.png' WHERE CountryName = 'Belgium'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\bulgaria.png' WHERE CountryName = 'Bulgaria'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\cyprus.png' WHERE CountryName = 'Cyprus'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\czech.png' WHERE CountryName = 'Czech Republic'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\denmark.png' WHERE CountryName = 'Denmark'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\estonia.png' WHERE CountryName = 'Estonia'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\finland.png' WHERE CountryName = 'Finland'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\france.png' WHERE CountryName = 'France'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\germany.png' WHERE CountryName = 'Germany'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\greece.png' WHERE CountryName = 'Greece'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\hungary.png' WHERE CountryName = 'Hungary'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\ireland.png' WHERE CountryName = 'Ireland'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\italy.png' WHERE CountryName = 'Italy'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\latvia.png' WHERE CountryName = 'Latvia'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\lithuania.png' WHERE CountryName = 'Lithuania'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\luxembourg.png' WHERE CountryName = 'Luxembourg'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\malta.png' WHERE CountryName = 'Malta'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\netherlands.png' WHERE CountryName = 'Netherlands'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\poland.png' WHERE CountryName = 'Poland'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\portugal.png' WHERE CountryName = 'Portugal'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\romania.png' WHERE CountryName = 'Romania'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\slovakia.png' WHERE CountryName = 'Slovakia'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\slovenia.png' WHERE CountryName = 'Slovenia'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\spain.png' WHERE CountryName = 'Spain'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\sweden.png' WHERE CountryName = 'Sweden'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\uk.png' WHERE CountryName = 'United Kingdom'");
            Sql("UPDATE GeneralDatas SET Flag = 'images\\cyprus.png' WHERE CountryName = 'United Kingdom'");
        }
        
        public override void Down()
        {
            DropColumn("dbo.GeneralDatas", "Flag");
        }
    }
}
