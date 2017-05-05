namespace ItRequitments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("JobOffers", "company_CompanyId", c => c.Int());
            CreateIndex("JobOffers", "company_CompanyId");
            AddForeignKey("JobOffers", "company_CompanyId", "Companies", "CompanyId");
        }
        
        public override void Down()
        {
            DropForeignKey("JobOffers", "company_CompanyId", "Companies");
            DropIndex("JobOffers", new[] { "company_CompanyId" });
            DropColumn("JobOffers", "company_CompanyId");
        }
    }
}
