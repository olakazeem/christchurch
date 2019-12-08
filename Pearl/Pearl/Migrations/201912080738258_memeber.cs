namespace Pearl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class memeber : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "mTitle", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Members", "mSurname", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Members", "mFirstname", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Members", "mOthername", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "mOthername", c => c.String(maxLength: 150));
            AlterColumn("dbo.Members", "mFirstname", c => c.String(maxLength: 150));
            AlterColumn("dbo.Members", "mSurname", c => c.String(maxLength: 150));
            AlterColumn("dbo.Members", "mTitle", c => c.String(maxLength: 10));
        }
    }
}
