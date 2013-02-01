namespace BiteCards.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFKToImagesTable_RemoveExtraFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CardImages", "ImageUrl", c => c.String());
            AddColumn("dbo.CardImages", "Card_CardId", c => c.Int());
            AddForeignKey("dbo.CardImages", "Card_CardId", "dbo.Cards", "CardId");
            CreateIndex("dbo.CardImages", "Card_CardId");
            DropColumn("dbo.Cards", "ImageId");
            DropColumn("dbo.CardImages", "FrontImageUrl");
            DropColumn("dbo.CardImages", "InnetImageUrl");
            DropColumn("dbo.CardImages", "RearImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CardImages", "RearImageUrl", c => c.String());
            AddColumn("dbo.CardImages", "InnetImageUrl", c => c.String());
            AddColumn("dbo.CardImages", "FrontImageUrl", c => c.String());
            AddColumn("dbo.Cards", "ImageId", c => c.Int(nullable: false));
            DropIndex("dbo.CardImages", new[] { "Card_CardId" });
            DropForeignKey("dbo.CardImages", "Card_CardId", "dbo.Cards");
            DropColumn("dbo.CardImages", "Card_CardId");
            DropColumn("dbo.CardImages", "ImageUrl");
        }
    }
}
