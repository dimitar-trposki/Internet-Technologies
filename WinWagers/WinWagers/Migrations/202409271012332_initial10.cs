namespace WinWagers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial10 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Tickets", new[] { "User_Id" });
            DropColumn("dbo.Tickets", "UserId");
            RenameColumn(table: "dbo.Tickets", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Tickets", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Tickets", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Tickets", new[] { "UserId" });
            AlterColumn("dbo.Tickets", "UserId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Tickets", name: "UserId", newName: "User_Id");
            AddColumn("dbo.Tickets", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tickets", "User_Id");
        }
    }
}
