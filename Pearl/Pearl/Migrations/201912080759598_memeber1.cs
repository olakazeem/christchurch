namespace Pearl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class memeber1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "mGender", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.Members", "mMaritalStatus", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Members", "mAddress", c => c.String(nullable: false, maxLength: 350));
            AlterColumn("dbo.Members", "mArea", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Members", "mNearestBustop", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Members", "mLGA", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Members", "mEmail", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Members", "mPhoneNo1", c => c.String(nullable: false, maxLength: 14));
            AlterColumn("dbo.Members", "mSpouseName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Members", "mSpouseDOB", c => c.String(nullable: false));
            AlterColumn("dbo.Members", "mSpouseEmail", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Members", "mAltarCallChurch", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Members", "mDept", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Members", "mAreaOfInterest", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Members", "mSuggestion", c => c.String(nullable: false, maxLength: 350));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "mSuggestion", c => c.String(maxLength: 350));
            AlterColumn("dbo.Members", "mAreaOfInterest", c => c.String(maxLength: 150));
            AlterColumn("dbo.Members", "mDept", c => c.String(maxLength: 50));
            AlterColumn("dbo.Members", "mAltarCallChurch", c => c.String(maxLength: 50));
            AlterColumn("dbo.Members", "mSpouseEmail", c => c.String(maxLength: 250));
            AlterColumn("dbo.Members", "mSpouseDOB", c => c.String());
            AlterColumn("dbo.Members", "mSpouseName", c => c.String(maxLength: 150));
            AlterColumn("dbo.Members", "mPhoneNo1", c => c.String(maxLength: 14));
            AlterColumn("dbo.Members", "mEmail", c => c.String(maxLength: 250));
            AlterColumn("dbo.Members", "mLGA", c => c.String(maxLength: 70));
            AlterColumn("dbo.Members", "mNearestBustop", c => c.String(maxLength: 100));
            AlterColumn("dbo.Members", "mArea", c => c.String(maxLength: 100));
            AlterColumn("dbo.Members", "mAddress", c => c.String(maxLength: 350));
            AlterColumn("dbo.Members", "mMaritalStatus", c => c.String(maxLength: 10));
            AlterColumn("dbo.Members", "mGender", c => c.String(maxLength: 6));
        }
    }
}
