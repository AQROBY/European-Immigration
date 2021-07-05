namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQualityOfLifeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QualityOfLives",
                c => new
                    {
                        CountryName = c.String(nullable: false, maxLength: 128),
                        QualityOfLifeIndex = c.Decimal(precision: 18, scale: 2),
                        PurchasingPowerIndex = c.Decimal(precision: 18, scale: 2),
                        safetyIndex = c.Decimal(precision: 18, scale: 2),
                        healthcareIndex = c.Decimal(precision: 18, scale: 2),
                        costOfLivingIndex = c.Decimal(precision: 18, scale: 2),
                        propertyPriceToIncomeRatio = c.Decimal(precision: 18, scale: 2),
                        trafficCommuteTimeIndex = c.Decimal(precision: 18, scale: 2),
                        pollutionIndex = c.Decimal(precision: 18, scale: 2),
                        climateIndex = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CountryName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QualityOfLives");
        }
    }
}
