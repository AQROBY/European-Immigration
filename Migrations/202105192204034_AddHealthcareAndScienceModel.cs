namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHealthcareAndScienceModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HealthcareAndSciences",
                c => new
                    {
                        CountryName = c.String(nullable: false, maxLength: 128),
                        HealthcareIndex = c.Decimal(precision: 18, scale: 2),
                        LifeExpectancy = c.Decimal(precision: 18, scale: 2),
                        ScientificDocumentsHIndex = c.Int(),
                        HumanDevelopmentIndex = c.Decimal(precision: 18, scale: 3),
                    })
                .PrimaryKey(t => t.CountryName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HealthcareAndSciences");
        }
    }
}
