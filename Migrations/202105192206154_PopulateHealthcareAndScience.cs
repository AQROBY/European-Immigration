namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateHealthcareAndScience : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO HealthcareAndSciences (CountryName, HealthcareIndex, LifeExpectancy, ScientificDocumentsHIndex, HumanDevelopmentIndex) VALUES" +
                "('Austria', '79.46', '81.5', 620, '0.908')," +
                "('Belgium', '78.30', '81.1', 748, '0.916')," +
                "('Bulgaria', '55.07', '74.5', 240, '0.813')," +
                "('Cyprus', '52.06', '80.5', 192, '0.869')," +
                "('Czech Republic', '74.47', '78.8', 427, '0.888')," +
                "('Denmark', '79.22', '80.6', 705, '0.929')," +
                "('Estonia', '68.49', '77.6', 255, '0.871')," +
                "('Finland', '75.27', '81.1', 609, '0.920')," +
                "('France', '78.34', '82.4', 1094, '0.901')," +
                "('Germany', '73.58', '81.0', 1203, '0.936')," +
                "('Greece', '55.48', '81.0', 466, '0.870')," +
                "('Hungary', '47.62', '75.9', 419, '0.838')," +
                "('Ireland', '51.44', '81.4', 488, '0.938')," +
                "('Italy', '66.56', '82.7', 953, '0.880')," +
                "('Latvia', '63.73', '74.6', 151, '0.847')," +
                "('Lithuania', '68.79', '73.6', 203, '0.858')," +
                "('Luxembourg', '73.41', '82.0', 173, '0.904')," +
                "('Malta', '70.98', '81.7', 114, '0.878')," +
                "('Netherlands', '75.63', '81.9', 957, '0.931')," +
                "('Poland', '62.52', '77.5', 519, '0.865')," +
                "('Portugal', '71.64', '81.1', 457, '0.847')," +
                "('Romania', '54.99', '75.0', 271, '0.811')," +
                "('Slovakia', '60.46', '76.7', 263, '0.855')," +
                "('Slovenia', '63.75', '80.8', 278, '0.896')," +
                "('Spain', '78.42', '82.8', 830, '0.891')," +
                "('Sweden', '69.41', '82.4', 825, '0.933')," +
                "('United Kingdom', '74.88', '81.2', 1373, '0.922')");
        }
        
        public override void Down()
        {
        }
    }
}
