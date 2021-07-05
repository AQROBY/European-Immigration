namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaxesModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Taxes",
                c => new
                    {
                        CountryName = c.String(nullable: false, maxLength: 128),
                        CorporateTax = c.String(),
                        IncomeTax = c.String(),
                        Vat = c.String(),
                    })
                .PrimaryKey(t => t.CountryName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Taxes");
        }
    }
}
