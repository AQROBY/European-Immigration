namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePoliticsAndEconomics : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PoliticsAndEconomics (CountryName, RuleOfLawIndex, PoliticalStabilityIndex, CorruptionIndex, StateFragilityIndex, EconomicGrowth, GdpPerCapita) VALUES" +
                "('Austria', '1.81', '1.04', 76, '26.20', '2.55%', '47,380')," +
                "('Belgium', '1.34', '0.42', 75, '29.70', '1.69%', '43,467')," +
                "('Bulgaria', '-0.04', '0.37', 42, '51.70', '3.81%', '8,228')," +
                "('Cyprus', '0.88', '0.60', 59, '60.30', '4.23%', '25,685')," +
                "('Czech Republic', '1.12', '1.02', 59, '39.00', '4.35%', '20,379')," +
                "('Denmark', '1.86', '0.87', 88, '19.80', '2.26%', '57,218')," +
                "('Estonia', '1.28', '0.66', 73, '43.00', '4.86%', '20,200')," +
                "('Finland', '2.03', '1.07', 85, '17.90', '2.65%', '45,804')," +
                "('France', '1.44', '0.21', 72, '32.20', '2.16%', '38,484')," +
                "('Germany', '1.61', '0.58', 80, '25.80', '2.16%', '44,665')," +
                "('Greece', '0.08', '-0.13', 45, '55.30', '1.51%', '18,885')," +
                "('Hungary', '0.53', '0.81', 46, '50.20', '4.14%', '14,278')," +
                "('Ireland', '1.43', '1.02', 73, '20.70', '7.22%', '68,885')," +
                "('Italy', '0.32', '0.24', 52, '43.80', '1.57%', '32,110')," +
                "('Latvia', '0.93', '0.46', 58, '44.90', '4.64%', '15,684')," +
                "('Lithuania', '0.99', '0.78', 59, '39.40', '4.14%', '16,809')," +
                "('Luxembourg', '1.74', '1.34', 81, '20.80', '1.55%', '104,498')," +
                "('Malta', '1.14', '1.27', 54, '36.20', '6.42%', '26,748')," +
                "('Netherlands', '1.83', '0.92', 82, '26.20', '2.87%', '48,482')," +
                "('Poland', '0.47', '0.52', 60, '41.50', '4.81%', '13,863')," +
                "('Portugal', '1.13', '1.08', 64, '27.30', '2.80%', '21,291')," +
                "('Romania', '0.39', '0.06', 47, '49.40', '7.26%', '10,819')," +
                "('Slovakia', '0.57', '0.88', 50, '42.50', '3.19%', '17,579')," +
                "('Slovenia', '1.02', '0.89', 60, '30.30', '5.00%', '23,601')," +
                "('Spain', '1.01', '0.27', 58, '41.40', '2.98%', '28,208')," +
                "('Sweden', '1.94', '0.98', 85, '20.80', '2.10%', '53,253')," +
                "('United Kingdom', '1.68', '0.26', 80, '34.30', '1.82%', '39,953')");
        }
        
        public override void Down()
        {
        }
    }
}
