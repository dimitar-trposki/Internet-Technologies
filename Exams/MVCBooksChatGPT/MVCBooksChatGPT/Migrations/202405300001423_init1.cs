namespace MVCBooksChatGPT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Biography = c.String(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ISBN = c.String(),
                        ImageUrl = c.String(),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Libraries",
                c => new
                    {
                        LibraryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.LibraryId);
            
            CreateTable(
                "dbo.Librarians",
                c => new
                    {
                        LibrarianId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LibraryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LibrarianId)
                .ForeignKey("dbo.Libraries", t => t.LibraryId, cascadeDelete: true)
                .Index(t => t.LibraryId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        ContactNumber = c.String(),
                        MembershipNumber = c.Int(nullable: false),
                        Status = c.String(),
                        Library_LibraryId = c.Int(),
                    })
                .PrimaryKey(t => t.MemberId)
                .ForeignKey("dbo.Libraries", t => t.Library_LibraryId)
                .Index(t => t.Library_LibraryId);
            
            CreateTable(
                "dbo.LibraryBooks",
                c => new
                    {
                        Library_LibraryId = c.Int(nullable: false),
                        Book_BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Library_LibraryId, t.Book_BookId })
                .ForeignKey("dbo.Libraries", t => t.Library_LibraryId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_BookId, cascadeDelete: true)
                .Index(t => t.Library_LibraryId)
                .Index(t => t.Book_BookId);
            
            CreateTable(
                "dbo.MemberBooks",
                c => new
                    {
                        Member_MemberId = c.Int(nullable: false),
                        Book_BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Member_MemberId, t.Book_BookId })
                .ForeignKey("dbo.Members", t => t.Member_MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_BookId, cascadeDelete: true)
                .Index(t => t.Member_MemberId)
                .Index(t => t.Book_BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Library_LibraryId", "dbo.Libraries");
            DropForeignKey("dbo.MemberBooks", "Book_BookId", "dbo.Books");
            DropForeignKey("dbo.MemberBooks", "Member_MemberId", "dbo.Members");
            DropForeignKey("dbo.Librarians", "LibraryId", "dbo.Libraries");
            DropForeignKey("dbo.LibraryBooks", "Book_BookId", "dbo.Books");
            DropForeignKey("dbo.LibraryBooks", "Library_LibraryId", "dbo.Libraries");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.MemberBooks", new[] { "Book_BookId" });
            DropIndex("dbo.MemberBooks", new[] { "Member_MemberId" });
            DropIndex("dbo.LibraryBooks", new[] { "Book_BookId" });
            DropIndex("dbo.LibraryBooks", new[] { "Library_LibraryId" });
            DropIndex("dbo.Members", new[] { "Library_LibraryId" });
            DropIndex("dbo.Librarians", new[] { "LibraryId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.MemberBooks");
            DropTable("dbo.LibraryBooks");
            DropTable("dbo.Members");
            DropTable("dbo.Librarians");
            DropTable("dbo.Libraries");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
