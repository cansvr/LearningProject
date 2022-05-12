namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        ROLE_CODE = c.Int(nullable: false, identity: true),
                        ROLE_NAME = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ROLE_CODE);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        USER_CODE = c.Int(nullable: false, identity: true),
                        USER_NAME = c.String(maxLength: 100),
                        USER_SURNAME = c.String(maxLength: 100),
                        USER_IMAGE = c.String(maxLength: 100),
                        USER_ABOUT = c.String(maxLength: 300),
                        USER_PASSWORD = c.String(maxLength: 100),
                        USER_MAIL = c.String(maxLength: 100),
                        USER_TITLE = c.String(maxLength: 100),
                        ROLE_CODE = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.USER_CODE)
                .ForeignKey("dbo.UserRoles", t => t.ROLE_CODE, cascadeDelete: true)
                .Index(t => t.ROLE_CODE);
            
            CreateTable(
                "dbo.Writers",
                c => new
                    {
                        WRITER_CODE = c.Int(nullable: false, identity: true),
                        WRITER_NAME = c.String(maxLength: 100),
                        WRITER_SURNAME = c.String(maxLength: 100),
                        WRITER_IMAGE = c.String(maxLength: 100),
                        WRITER_ABOUT = c.String(maxLength: 100),
                        WRITER_PASSWORD = c.String(maxLength: 100),
                        WRITER_MAIL = c.String(maxLength: 100),
                        WRITER_TITLE = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.WRITER_CODE);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "ROLE_CODE", "dbo.UserRoles");
            DropIndex("dbo.Users", new[] { "ROLE_CODE" });
            DropTable("dbo.Writers");
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
        }
    }
}
