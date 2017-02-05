namespace SBMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versionTwo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerPaymentModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.String(),
                        Amount = c.Single(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerPaymentModels");
        }
    }
}
