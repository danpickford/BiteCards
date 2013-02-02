namespace BiteCardEntityModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cards", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Messages", "Card_CardId", "dbo.Cards");
            DropIndex("dbo.Cards", new[] { "Order_OrderId" });
            DropIndex("dbo.Messages", new[] { "Card_CardId" });
            DropColumn("dbo.Cards", "Order_OrderId");
            DropTable("dbo.Messages");
            DropTable("dbo.Orders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        CardId = c.Int(nullable: false),
                        TotalBilled = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        MessageText = c.String(),
                        Card_CardId = c.Int(),
                    })
                .PrimaryKey(t => t.MessageId);
            
            AddColumn("dbo.Cards", "Order_OrderId", c => c.Int());
            CreateIndex("dbo.Messages", "Card_CardId");
            CreateIndex("dbo.Cards", "Order_OrderId");
            AddForeignKey("dbo.Messages", "Card_CardId", "dbo.Cards", "CardId");
            AddForeignKey("dbo.Cards", "Order_OrderId", "dbo.Orders", "OrderId");
        }
    }
}
