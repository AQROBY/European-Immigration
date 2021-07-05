namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAndPopulateHealthcareWithFlags : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HealthcareAndSciences", "Flag", c => c.String());

        }
        
        public override void Down()
        {
            DropColumn("dbo.HealthcareAndSciences", "Flag");
        }
    }
}
