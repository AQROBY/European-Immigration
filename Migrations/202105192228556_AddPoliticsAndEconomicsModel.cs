namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPoliticsAndEconomicsModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PoliticsAndEconomics",
                c => new
                    {
                        CountryName = c.String(nullable: false, maxLength: 128),
                        RuleOfLawIndex = c.Decimal(precision: 18, scale: 2),
                        PoliticalStabilityIndex = c.Decimal(precision: 18, scale: 2),
                        CorruptionIndex = c.Int(),
                        StateFragilityIndex = c.Decimal(precision: 18, scale: 2),
                        EconomicGrowth = c.String(),
                        GdpPerCapita = c.String(),
                    })
                .PrimaryKey(t => t.CountryName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PoliticsAndEconomics");
        }
    }
}
