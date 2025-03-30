namespace WinWagers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial11 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Tickets", name: "UserId", newName: "User_Id");
            RenameIndex(table: "dbo.Tickets", name: "IX_UserId", newName: "IX_User_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Tickets", name: "IX_User_Id", newName: "IX_UserId");
            RenameColumn(table: "dbo.Tickets", name: "User_Id", newName: "UserId");
        }
    }
}
