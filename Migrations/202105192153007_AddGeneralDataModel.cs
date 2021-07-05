namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGeneralDataModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GeneralDatas",
                c => new
                    {
                        CountryName = c.String(nullable: false, maxLength: 128),
                        CostOfLiving = c.Decimal(precision: 18, scale: 2),
                        RentIndex = c.Decimal(precision: 18, scale: 2),
                        CostOfLivingPlusRentIndex = c.Decimal(precision: 18, scale: 2),
                        GroceriesIndex = c.Decimal(precision: 18, scale: 2),
                        TaxRateIncome = c.String(),
                        LocalPurchasingPowerIndex = c.Decimal(precision: 18, scale: 2),
                        SafetyIndex = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CountryName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GeneralDatas");
        }
    }
}
