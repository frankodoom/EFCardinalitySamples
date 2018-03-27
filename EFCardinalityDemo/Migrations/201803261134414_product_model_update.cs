namespace EFCardinalityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product_model_update : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "ProductImageId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProductImageId", c => c.Int(nullable: false));
        }
    }
}
