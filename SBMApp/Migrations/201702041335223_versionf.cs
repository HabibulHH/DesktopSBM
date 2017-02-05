namespace SBMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versionf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerBuyingRecs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Single(nullable: false),
                        CustomerSL = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SellsRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        TotalSell = c.Single(nullable: false),
                        SellOnCash = c.Single(nullable: false),
                        SellsOnDue = c.Single(nullable: false),
                        Collection = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SellsRecords");
            DropTable("dbo.CustomerBuyingRecs");
        }
    }
}
