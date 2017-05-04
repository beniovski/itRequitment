namespace ItRequitments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodaniepola : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "nowePole", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "nowePole");
        }
    }
}
