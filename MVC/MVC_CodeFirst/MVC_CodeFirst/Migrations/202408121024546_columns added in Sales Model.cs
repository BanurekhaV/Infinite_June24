namespace MVC_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class columnsaddedinSalesModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "QtySold", c => c.Int(nullable: false));
            AddColumn("dbo.Sales", "ToTalampunt", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sales", "ToTalampunt");
            DropColumn("dbo.Sales", "QtySold");
        }
    }
}
