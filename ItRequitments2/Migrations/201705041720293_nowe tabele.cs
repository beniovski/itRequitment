namespace ItRequitments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nowetabele : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Id = c.Guid(nullable: false),
                        Login = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        Phone = c.String(unicode: false),
                        Email = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        Description = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        ConfirmPassword = c.String(unicode: false),
                        Addres = c.String(unicode: false),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.JobOffers",
                c => new
                    {
                        JobOfferId = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false, precision: 0),
                        EndTime = c.DateTime(nullable: false, precision: 0),
                        Title = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        Placement = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.JobOfferId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.JobOffers");
            DropTable("dbo.Company");
        }
    }
}
