namespace MVC_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class procedureremoved : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        SaleId = c.Int(nullable: false, identity: true),
                        dtofSale = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SaleId);
            
            AddColumn("dbo.Products", "Sales_SaleId", c => c.Int());
            CreateIndex("dbo.Products", "Sales_SaleId");
            AddForeignKey("dbo.Products", "Sales_SaleId", "dbo.Sales", "SaleId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Sales_SaleId", "dbo.Sales");
            DropIndex("dbo.Products", new[] { "Sales_SaleId" });
            DropColumn("dbo.Products", "Sales_SaleId");
            DropTable("dbo.Sales");
        }
    }
}
