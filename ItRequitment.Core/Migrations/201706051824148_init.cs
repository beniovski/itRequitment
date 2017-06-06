
namespace ItRequitment.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 10),
                        CompanyName = c.String(nullable: false, maxLength: 10),
                        Phone = c.String(),
                        Email = c.String(nullable: false, maxLength: 10),
                        Description = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                        City = c.String(nullable: false),
                        Addres = c.String(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.JobOffers",
                c => new
                    {
                        JobOfferId = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                        Requirements = c.String(),
                        Salary = c.String(),
                        Placement = c.String(nullable: false),
                        Company_CompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.JobOfferId)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyId)
                .Index(t => t.Company_CompanyId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 10),
                        Phone = c.String(),
                        Email = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        LastName = c.String(nullable: false, maxLength: 15),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                        Addres = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobOffers", "Company_CompanyId", "dbo.Companies");
            DropIndex("dbo.JobOffers", new[] { "Company_CompanyId" });
            DropTable("dbo.Users");
            DropTable("dbo.JobOffers");
            DropTable("dbo.Companies");
        }
    }
}
