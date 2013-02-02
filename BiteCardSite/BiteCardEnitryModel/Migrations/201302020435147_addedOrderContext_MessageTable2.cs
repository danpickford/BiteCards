namespace BiteCardEntityModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedOrderContext_MessageTable2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        MessageText = c.String(),
                        Card_CardId = c.Int(),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.Cards", t => t.Card_CardId)
                .Index(t => t.Card_CardId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        CardId = c.Int(nullable: false),
                        TotalBilled = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
            AddColumn("dbo.Cards", "Order_OrderId", c => c.Int());
            AddForeignKey("dbo.Cards", "Order_OrderId", "dbo.Orders", "OrderId");
            CreateIndex("dbo.Cards", "Order_OrderId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Messages", new[] { "Card_CardId" });
            DropIndex("dbo.Cards", new[] { "Order_OrderId" });
            DropForeignKey("dbo.Messages", "Card_CardId", "dbo.Cards");
            DropForeignKey("dbo.Cards", "Order_OrderId", "dbo.Orders");
            DropColumn("dbo.Cards", "Order_OrderId");
            DropTable("dbo.Orders");
            DropTable("dbo.Messages");
        }
    }
}
