namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateHealthcareWithFlags : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\austria.png' WHERE CountryName = 'Austria'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\belgium.png' WHERE CountryName = 'Belgium'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\bulgaria.png' WHERE CountryName = 'Bulgaria'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\cyprus.png' WHERE CountryName = 'Cyprus'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\czech.png' WHERE CountryName = 'Czech Republic'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\denmark.png' WHERE CountryName = 'Denmark'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\estonia.png' WHERE CountryName = 'Estonia'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\finland.png' WHERE CountryName = 'Finland'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\france.png' WHERE CountryName = 'France'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\germany.png' WHERE CountryName = 'Germany'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\greece.png' WHERE CountryName = 'Greece'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\hungary.png' WHERE CountryName = 'Hungary'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\ireland.png' WHERE CountryName = 'Ireland'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\italy.png' WHERE CountryName = 'Italy'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\latvia.png' WHERE CountryName = 'Latvia'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\lithuania.png' WHERE CountryName = 'Lithuania'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\luxembourg.png' WHERE CountryName = 'Luxembourg'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\malta.png' WHERE CountryName = 'Malta'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\netherlands.png' WHERE CountryName = 'Netherlands'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\poland.png' WHERE CountryName = 'Poland'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\portugal.png' WHERE CountryName = 'Portugal'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\romania.png' WHERE CountryName = 'Romania'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\slovakia.png' WHERE CountryName = 'Slovakia'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\slovenia.png' WHERE CountryName = 'Slovenia'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\spain.png' WHERE CountryName = 'Spain'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\sweden.png' WHERE CountryName = 'Sweden'");
            Sql("UPDATE HealthcareAndSciences SET Flag = '\\images\\uk.png' WHERE CountryName = 'United Kingdom'");
        }
        
        public override void Down()
        {
        }
    }
}
