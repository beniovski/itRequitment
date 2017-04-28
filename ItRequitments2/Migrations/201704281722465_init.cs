namespace ItRequitments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Int(nullable: false),
                        Login = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        Phone = c.String(unicode: false),
                        Email = c.String(nullable: false, unicode: false),
                        Name = c.String(nullable: false, unicode: false),
                        Description = c.String(unicode: false),
                        LastName = c.String(nullable: false, unicode: false),
                        Password = c.String(nullable: false, unicode: false),
                        ConfirmPassword = c.String(unicode: false),
                        Addres = c.String(unicode: false),
                        CreationDate = c.DateTime(nullable: false, precision: 0),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
