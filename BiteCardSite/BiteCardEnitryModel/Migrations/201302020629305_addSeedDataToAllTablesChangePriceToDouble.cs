namespace BiteCardEntityModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSeedDataToAllTablesChangePriceToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Prices", "Total", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Prices", "Total", c => c.Single(nullable: false));
        }
    }
}
