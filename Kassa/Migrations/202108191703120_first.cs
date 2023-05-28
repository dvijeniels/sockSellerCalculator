namespace Kassa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Qty = c.Int(nullable: false),
                        PurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RetailPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Solds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                        QtyAlan = c.Int(nullable: false),
                        QtyGetiren = c.Int(nullable: false),
                        WorkerPriceTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CompanyPriceTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Products_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.Products_ID)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.Products_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        KullaniciAdi = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        TelNumara = c.String(maxLength: 50),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Solds", "UserId", "dbo.Users");
            DropForeignKey("dbo.Solds", "Products_ID", "dbo.Products");
            DropIndex("dbo.Solds", new[] { "Products_ID" });
            DropIndex("dbo.Solds", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Solds");
            DropTable("dbo.Products");
        }
    }
}
