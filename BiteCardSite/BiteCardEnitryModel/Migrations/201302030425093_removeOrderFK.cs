namespace BiteCardEntityModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeOrderFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cards", "Order_OrderId", "dbo.Orders");
            DropIndex("dbo.Cards", new[] { "Order_OrderId" });
            AddColumn("dbo.Messages", "Order_OrderId", c => c.Int());
            AddForeignKey("dbo.Messages", "Order_OrderId", "dbo.Orders", "OrderId");
            CreateIndex("dbo.Messages", "Order_OrderId");
            DropColumn("dbo.Cards", "Order_OrderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cards", "Order_OrderId", c => c.Int());
            DropIndex("dbo.Messages", new[] { "Order_OrderId" });
            DropForeignKey("dbo.Messages", "Order_OrderId", "dbo.Orders");
            DropColumn("dbo.Messages", "Order_OrderId");
            CreateIndex("dbo.Cards", "Order_OrderId");
            AddForeignKey("dbo.Cards", "Order_OrderId", "dbo.Orders", "OrderId");
        }
    }
}
