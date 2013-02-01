namespace BiteCards.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test_effect_remove_listItemsFromCard : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Category", "Card_CardId", "dbo.Cards");
            DropForeignKey("dbo.Prices", "Card_CardId", "dbo.Cards");
            DropForeignKey("dbo.CardImages", "Card_CardId", "dbo.Cards");
            DropIndex("dbo.Category", new[] { "Card_CardId" });
            DropIndex("dbo.Prices", new[] { "Card_CardId" });
            DropIndex("dbo.CardImages", new[] { "Card_CardId" });
            DropColumn("dbo.Prices", "Card_CardId");
            DropColumn("dbo.CardImages", "Card_CardId");
            DropTable("dbo.Category");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Card_CardId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            AddColumn("dbo.CardImages", "Card_CardId", c => c.Int());
            AddColumn("dbo.Prices", "Card_CardId", c => c.Int());
            CreateIndex("dbo.CardImages", "Card_CardId");
            CreateIndex("dbo.Prices", "Card_CardId");
            CreateIndex("dbo.Categories", "Card_CardId");
            AddForeignKey("dbo.CardImages", "Card_CardId", "dbo.Cards", "CardId");
            AddForeignKey("dbo.Prices", "Card_CardId", "dbo.Cards", "CardId");
            AddForeignKey("dbo.Categories", "Card_CardId", "dbo.Cards", "CardId");
        }
    }
}
