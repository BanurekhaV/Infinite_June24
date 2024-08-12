namespace Storedproc_Prj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DId = c.Int(nullable: false, identity: true),
                        Dname = c.String(),
                    })
                .PrimaryKey(t => t.DId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ename = c.String(),
                        Salary = c.Double(nullable: false),
                        Department_DId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_DId)
                .Index(t => t.Department_DId);
            
            CreateStoredProcedure(
                "dbo.InsertEmployee",
                p => new
                    {
                        Ename = p.String(),
                        Salary = p.Double(),
                        Department_DId = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Employees]([Ename], [Salary], [Department_DId])
                      VALUES (@Ename, @Salary, @Department_DId)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Employees]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Employees] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.UpdateEmployee",
                p => new
                    {
                        Id = p.Int(),
                        Ename = p.String(),
                        Salary = p.Double(),
                        Department_DId = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Employees]
                      SET [Ename] = @Ename, [Salary] = @Salary, [Department_DId] = @Department_DId
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.DeleteEmplaoyee",
                p => new
                    {
                        Id = p.Int(),
                        Department_DId = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Employees]
                      WHERE (([Id] = @Id) AND (([Department_DId] = @Department_DId) OR ([Department_DId] IS NULL AND @Department_DId IS NULL)))"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.DeleteEmplaoyee");
            DropStoredProcedure("dbo.UpdateEmployee");
            DropStoredProcedure("dbo.InsertEmployee");
            DropForeignKey("dbo.Employees", "Department_DId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_DId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
