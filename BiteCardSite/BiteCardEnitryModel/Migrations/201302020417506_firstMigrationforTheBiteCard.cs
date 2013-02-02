namespace BiteCardEntityModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigrationforTheBiteCard : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        CardId = c.Int(nullable: false, identity: true),
                        CardName = c.String(),
                        CategoryId = c.Int(nullable: false),
                        PriceId = c.Int(nullable: false),
                        IsLandScape = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CardId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        PriceId = c.Int(nullable: false, identity: true),
                        Total = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.PriceId);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Card_CardId = c.Int(),
                    })
                .PrimaryKey(t => t.ImageId)
                .ForeignKey("dbo.Cards", t => t.Card_CardId)
                .Index(t => t.Card_CardId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Images", new[] { "Card_CardId" });
            DropForeignKey("dbo.Images", "Card_CardId", "dbo.Cards");
            DropTable("dbo.Images");
            DropTable("dbo.Prices");
            DropTable("dbo.Categories");
            DropTable("dbo.Cards");
        }
    }
}
