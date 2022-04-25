namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Writers",
                c => new
                    {
                        WRITER_CODE = c.Int(nullable: false, identity: true),
                        WRITER_NAME = c.String(maxLength: 100),
                        WRITER_SURNAME = c.String(maxLength: 100),
                        WRITER_MAIL = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.WRITER_CODE);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Writers");
        }
    }
}
