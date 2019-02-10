namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _addmountCol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));

            //Sql("Create dbo.Function CalcAmount")
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Amount");
            DropColumn("dbo.Products", "Quantity");
        }
    }
}
