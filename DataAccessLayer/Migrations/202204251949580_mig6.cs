namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        ROLE_CODE = c.Int(nullable: false, identity: true),
                        ROLE_NAME = c.String(maxLength: 100),
                        USER_CODE = c.Int(nullable: false),
                        WRITER_CODE = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ROLE_CODE)
                .ForeignKey("dbo.Users", t => t.USER_CODE, cascadeDelete: true)
                .ForeignKey("dbo.Writers", t => t.WRITER_CODE, cascadeDelete: true)
                .Index(t => t.USER_CODE)
                .Index(t => t.WRITER_CODE);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "WRITER_CODE", "dbo.Writers");
            DropForeignKey("dbo.UserRoles", "USER_CODE", "dbo.Users");
            DropIndex("dbo.UserRoles", new[] { "WRITER_CODE" });
            DropIndex("dbo.UserRoles", new[] { "USER_CODE" });
            DropTable("dbo.UserRoles");
        }
    }
}
