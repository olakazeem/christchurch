namespace Pearl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfirstname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false));
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "FullName", c => c.String(nullable: false));
            
        }
    }
}
