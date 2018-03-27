namespace EFCardinalityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductImages",
                c => new
                    {
                        ProductImageId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductImageId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        CostPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductName = c.String(),
                        ProductModel = c.String(),
                        Description = c.String(),
                        ProductImageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductImages", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.ProductImages", new[] { "Product_ProductId" });
            DropTable("dbo.Products");
            DropTable("dbo.ProductImages");
        }
    }
}
