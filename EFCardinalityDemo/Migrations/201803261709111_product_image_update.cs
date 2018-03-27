namespace EFCardinalityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product_image_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductImageId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductImageId");
        }
    }
}
