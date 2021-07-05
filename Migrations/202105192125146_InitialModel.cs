namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryName = c.String(nullable: false, maxLength: 128),
                        Flag = c.String(),
                        Capital = c.String(),
                        Population = c.Int(),
                    })
                .PrimaryKey(t => t.CountryName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Countries");
        }
    }
}
