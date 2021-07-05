namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullableDataToNumericTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GeneralDatas", "CostOfLiving", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.GeneralDatas", "RentIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.GeneralDatas", "CostOfLivingPlusRentIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.GeneralDatas", "GroceriesIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.GeneralDatas", "LocalPurchasingPowerIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.GeneralDatas", "SafetyIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.HealthcareAndSciences", "HealthcareIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.HealthcareAndSciences", "LifeExpectancy", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.HealthcareAndSciences", "ScientificDocumentsHIndex", c => c.Int());
            AlterColumn("dbo.HealthcareAndSciences", "HumanDevelopmentIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PoliticsAndEconomics", "RuleOfLawIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PoliticsAndEconomics", "PoliticalStabilityIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PoliticsAndEconomics", "CorruptionIndex", c => c.Int());
            AlterColumn("dbo.PoliticsAndEconomics", "StateFragilityIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "QualityOfLifeIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "PurchasingPowerIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "safetyIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "healthcareIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "costOfLivingIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "propertyPriceToIncomeRatio", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "trafficCommuteTimeIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "pollutionIndex", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "climateIndex", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.QualityOfLives", "climateIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "pollutionIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "trafficCommuteTimeIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "propertyPriceToIncomeRatio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "costOfLivingIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "healthcareIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "safetyIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "PurchasingPowerIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.QualityOfLives", "QualityOfLifeIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PoliticsAndEconomics", "StateFragilityIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PoliticsAndEconomics", "CorruptionIndex", c => c.Int(nullable: false));
            AlterColumn("dbo.PoliticsAndEconomics", "PoliticalStabilityIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PoliticsAndEconomics", "RuleOfLawIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.HealthcareAndSciences", "HumanDevelopmentIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.HealthcareAndSciences", "ScientificDocumentsHIndex", c => c.Int(nullable: false));
            AlterColumn("dbo.HealthcareAndSciences", "LifeExpectancy", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.HealthcareAndSciences", "HealthcareIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.GeneralDatas", "SafetyIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.GeneralDatas", "LocalPurchasingPowerIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.GeneralDatas", "GroceriesIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.GeneralDatas", "CostOfLivingPlusRentIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.GeneralDatas", "RentIndex", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.GeneralDatas", "CostOfLiving", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
