namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "USER_ABOUT", c => c.String(maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "USER_ABOUT", c => c.String(maxLength: 600));
        }
    }
}
