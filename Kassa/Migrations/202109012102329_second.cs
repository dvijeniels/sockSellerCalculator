namespace Kassa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Solds", "QtyAlan");
            DropColumn("dbo.Solds", "QtyGetiren");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Solds", "QtyGetiren", c => c.Int(nullable: false));
            AddColumn("dbo.Solds", "QtyAlan", c => c.Int(nullable: false));
        }
    }
}
