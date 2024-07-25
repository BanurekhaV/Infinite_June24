namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedAuthorsModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            AddColumn("dbo.tblBooks", "YearPublished", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblBooks", "YearPublished");
            DropTable("dbo.Authors");
        }
    }
}
