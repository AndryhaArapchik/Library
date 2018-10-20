namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Patronymic = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        DateOfBirth = c.String(),
                        DateOfDeath = c.String(),
                        Description = c.String(),
                        EditingDate = c.DateTime(nullable: false),
                        Editor_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Editor_Id)
                .Index(t => t.Editor_Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Year = c.Int(nullable: false),
                        Condition = c.Int(nullable: false),
                        Description = c.String(),
                        PossibilityIssuing = c.Boolean(nullable: false),
                        Tags = c.String(),
                        Term = c.Int(nullable: false),
                        DateRegistration = c.DateTime(nullable: false),
                        EditingDate = c.DateTime(nullable: false),
                        DateIssue = c.DateTime(nullable: false),
                        User_Id = c.Guid(),
                        Editor_Id = c.Guid(),
                        IssuedUser_Id = c.Guid(),
                        Publisher_Id = c.Guid(),
                        Reader_Id = c.Guid(),
                        WritingLanguage_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.Editor_Id)
                .ForeignKey("dbo.Users", t => t.IssuedUser_Id)
                .ForeignKey("dbo.Publishers", t => t.Publisher_Id)
                .ForeignKey("dbo.Users", t => t.Reader_Id)
                .ForeignKey("dbo.Languages", t => t.WritingLanguage_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Editor_Id)
                .Index(t => t.IssuedUser_Id)
                .Index(t => t.Publisher_Id)
                .Index(t => t.Reader_Id)
                .Index(t => t.WritingLanguage_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Patronymic = c.String(),
                        City = c.String(),
                        Address = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        PassportDetails = c.String(),
                        DateOfDeath = c.String(),
                        Rating = c.Int(nullable: false),
                        Description = c.String(),
                        EditingDate = c.DateTime(nullable: false),
                        Role = c.Int(nullable: false),
                        Editor_Id = c.Guid(),
                        Photo_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Editor_Id)
                .ForeignKey("dbo.Files", t => t.Photo_Id)
                .Index(t => t.Editor_Id)
                .Index(t => t.Photo_Id);
            
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MIME = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Path = c.String(),
                        Book_Id = c.Guid(),
                        Author_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.Authors", t => t.Author_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.Author_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        Rating = c.Int(nullable: false),
                        EditingDate = c.DateTime(nullable: false),
                        Editor_Id = c.Guid(),
                        Book_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Editor_Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.Editor_Id)
                .Index(t => t.Book_Id);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        Adress = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                        EditingDate = c.DateTime(nullable: false),
                        Editor_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Editor_Id)
                .Index(t => t.Editor_Id);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Decription = c.String(),
                        Rating = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        Author_Id = c.Guid(),
                        Publisher_Id = c.Guid(),
                        Book_Id = c.Guid(),
                        Author_Id1 = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author_Id)
                .ForeignKey("dbo.Publishers", t => t.Publisher_Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.Authors", t => t.Author_Id1)
                .Index(t => t.Author_Id)
                .Index(t => t.Publisher_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.Author_Id1);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Decription = c.String(),
                        Rating = c.String(),
                        EditingDate = c.DateTime(nullable: false),
                        Editor_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Editor_Id)
                .Index(t => t.Editor_Id);
            
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Book_Id = c.Guid(nullable: false),
                        Author_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_Id, t.Author_Id })
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .ForeignKey("dbo.Authors", t => t.Author_Id, cascadeDelete: true)
                .Index(t => t.Book_Id)
                .Index(t => t.Author_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Feedbacks", "Author_Id1", "dbo.Authors");
            DropForeignKey("dbo.Files", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.Authors", "Editor_Id", "dbo.Users");
            DropForeignKey("dbo.Books", "WritingLanguage_Id", "dbo.Languages");
            DropForeignKey("dbo.Languages", "Editor_Id", "dbo.Users");
            DropForeignKey("dbo.Feedbacks", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Books", "Reader_Id", "dbo.Users");
            DropForeignKey("dbo.Feedbacks", "Publisher_Id", "dbo.Publishers");
            DropForeignKey("dbo.Feedbacks", "Author_Id", "dbo.Users");
            DropForeignKey("dbo.Publishers", "Editor_Id", "dbo.Users");
            DropForeignKey("dbo.Books", "Publisher_Id", "dbo.Publishers");
            DropForeignKey("dbo.Files", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Books", "IssuedUser_Id", "dbo.Users");
            DropForeignKey("dbo.Genres", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Genres", "Editor_Id", "dbo.Users");
            DropForeignKey("dbo.Books", "Editor_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Photo_Id", "dbo.Files");
            DropForeignKey("dbo.Users", "Editor_Id", "dbo.Users");
            DropForeignKey("dbo.Books", "User_Id", "dbo.Users");
            DropForeignKey("dbo.BookAuthors", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.BookAuthors", "Book_Id", "dbo.Books");
            DropIndex("dbo.BookAuthors", new[] { "Author_Id" });
            DropIndex("dbo.BookAuthors", new[] { "Book_Id" });
            DropIndex("dbo.Languages", new[] { "Editor_Id" });
            DropIndex("dbo.Feedbacks", new[] { "Author_Id1" });
            DropIndex("dbo.Feedbacks", new[] { "Book_Id" });
            DropIndex("dbo.Feedbacks", new[] { "Publisher_Id" });
            DropIndex("dbo.Feedbacks", new[] { "Author_Id" });
            DropIndex("dbo.Publishers", new[] { "Editor_Id" });
            DropIndex("dbo.Genres", new[] { "Book_Id" });
            DropIndex("dbo.Genres", new[] { "Editor_Id" });
            DropIndex("dbo.Files", new[] { "Author_Id" });
            DropIndex("dbo.Files", new[] { "Book_Id" });
            DropIndex("dbo.Users", new[] { "Photo_Id" });
            DropIndex("dbo.Users", new[] { "Editor_Id" });
            DropIndex("dbo.Books", new[] { "WritingLanguage_Id" });
            DropIndex("dbo.Books", new[] { "Reader_Id" });
            DropIndex("dbo.Books", new[] { "Publisher_Id" });
            DropIndex("dbo.Books", new[] { "IssuedUser_Id" });
            DropIndex("dbo.Books", new[] { "Editor_Id" });
            DropIndex("dbo.Books", new[] { "User_Id" });
            DropIndex("dbo.Authors", new[] { "Editor_Id" });
            DropTable("dbo.BookAuthors");
            DropTable("dbo.Languages");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Publishers");
            DropTable("dbo.Genres");
            DropTable("dbo.Files");
            DropTable("dbo.Users");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
