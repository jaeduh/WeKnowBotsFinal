namespace WeKnowBots.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bot", "TypeOfBot", c => c.Int(nullable: false));
            AddColumn("dbo.Bot", "DateBotUsed", c => c.String(nullable: false));
            DropColumn("dbo.Bot", "CreatedUtc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bot", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.Bot", "DateBotUsed");
            DropColumn("dbo.Bot", "TypeOfBot");
        }
    }
}
