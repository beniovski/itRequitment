namespace ItRequitment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        Phone = c.String(unicode: false),
                        Email = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        Description = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        ConfirmPassword = c.String(unicode: false),
                        Addres = c.String(nullable: false, unicode: false),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "JobOffers",
                c => new
                    {
                        JobOfferId = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false, precision: 0),
                        EndTime = c.DateTime(nullable: false, precision: 0),
                        Title = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Description = c.String(unicode: false),
                        Requirements = c.String(unicode: false),
                        Placement = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.JobOfferId);
            
            CreateTable(
                "Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        Phone = c.String(unicode: false),
                        Email = c.String(nullable: false, unicode: false),
                        Name = c.String(nullable: false, unicode: false),
                        Description = c.String(unicode: false),
                        LastName = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        Password = c.String(nullable: false, unicode: false),
                        ConfirmPassword = c.String(unicode: false),
                        Addres = c.String(unicode: false),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("Users");
            DropTable("JobOffers");
            DropTable("Companies");
        }
    }
}
