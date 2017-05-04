namespace ItRequitments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodatek : DbMigration
    {
        public override void Up()
        {
            
            AddColumn("JobOffers", "Requirements", c => c.String(unicode: false));
            AlterColumn("Company", "Addres", c => c.String(nullable: false, unicode: false));
            AlterColumn("JobOffers", "Title", c => c.String(nullable: false, maxLength: 50, storeType: "nvarchar"));
            AlterColumn("JobOffers", "Placement", c => c.String(nullable: false, unicode: false));
            AlterColumn("Users", "UserId", c => c.Int(nullable: false, identity: true));
            AlterColumn("Users", "LastName", c => c.String(nullable: false, maxLength: 15, storeType: "nvarchar"));
            AddPrimaryKey("Users", "UserId");
            DropColumn("Company", "Id");
            DropColumn("Users", "Id");
            DropColumn("Users", "nowePole");
        }
        
        public override void Down()
        {
            AddColumn("Users", "nowePole", c => c.String(unicode: false));
            AddColumn("Users", "Id", c => c.Guid(nullable: false));
            AddColumn("Company", "Id", c => c.Guid(nullable: false));
            DropPrimaryKey("Users");
            AlterColumn("Users", "LastName", c => c.String(nullable: false, unicode: false));
            AlterColumn("Users", "UserId", c => c.Int(nullable: false));
            AlterColumn("JobOffers", "Placement", c => c.String(unicode: false));
            AlterColumn("JobOffers", "Title", c => c.String(unicode: false));
            AlterColumn("Company", "Addres", c => c.String(unicode: false));
            DropColumn("JobOffers", "Requirements");
            AddPrimaryKey("Users", "Id");
            RenameTable(name: "Company", newName: "Company");
        }
    }
}
