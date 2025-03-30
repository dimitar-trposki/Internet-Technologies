namespace WinWagers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Teams", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Description", c => c.String());
        }
    }
}
