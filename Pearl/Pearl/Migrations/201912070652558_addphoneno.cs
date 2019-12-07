namespace Pearl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addphoneno : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PhoneNo", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Gender", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "MaritalStatus", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "DateofBirth", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DateofBirth");
            DropColumn("dbo.AspNetUsers", "MaritalStatus");
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "PhoneNo");
        }
    }
}
