namespace WinWagers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Ticket_Id1", c => c.Int());
            CreateIndex("dbo.Games", "Ticket_Id1");
            AddForeignKey("dbo.Games", "Ticket_Id1", "dbo.Tickets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Ticket_Id1", "dbo.Tickets");
            DropIndex("dbo.Games", new[] { "Ticket_Id1" });
            DropColumn("dbo.Games", "Ticket_Id1");
        }
    }
}
