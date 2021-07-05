namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTaxes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Taxes (CountryName, CorporateTax, IncomeTax, Vat) VALUES" +
                "('Austria', '25%', '55%', '20%')," +
                "('Belgium', '29.58%', '50%', '21%')," +
                "('Bulgaria', '10%', '10%', '20%')," +
                "('Cyprus', '12.5%', '35%', '19%')," +
                "('Czech Republic', '19%', '45.7%', '21%')," +
                "('Denmark', '22%', '55.85%', '25%')," +
                "('Estonia', '0%', '20%', '20%')," +
                "('Finland', '20%', '54.25%', '24%')," +
                "('France', '31%', '45%', '20%')," +
                "('Germany', '29.65%', '47.47%', '19%')," +
                "('Greece', '28%', '45%', '24%')," +
                "('Hungary', '9%', '15%', '27%')," +
                "('Ireland', '12.5%', '52%', '23%')," +
                "('Italy', '27.9%', '47%', '22%')," +
                "('Latvia', '0%', '23%', '21%')," +
                "('Lithuania', '15%', '42.77%', '21%')," +
                "('Luxembourg', '29.22%', '52.45%', '17%')," +
                "('Malta', '10%', '35%', '18%')," +
                "('Netherlands', '25%', '51.95%', '21%')," +
                "('Poland', '19%', '32%', '23%')," +
                "('Portugal', '21%', '48%', '23%')," +
                "('Romania', '16%', '10%', '19%')," +
                "('Slovakia', '22%', '25%', '20%')," +
                "('Slovenia', '19%', '50%', '22%')," +
                "('Spain', '25%', '45%', '21%')," +
                "('Sweden', '21.4%', '57%', '25%')," +
                "('United Kingdom', '19%', '47%', '20%')");
        }
        
        public override void Down()
        {
        }
    }
}
