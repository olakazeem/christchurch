namespace Pearl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class member : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberID = c.Int(nullable: false, identity: true),
                        mTitle = c.String(maxLength: 10),
                        mSurname = c.String(maxLength: 150),
                        mFirstname = c.String(maxLength: 150),
                        mOthername = c.String(maxLength: 150),
                        mGender = c.String(maxLength: 6),
                        mMaritalStatus = c.String(maxLength: 10),
                        mBirthday = c.DateTime(nullable: false),
                        mAddress = c.String(maxLength: 350),
                        mArea = c.String(maxLength: 100),
                        mNearestBustop = c.String(maxLength: 100),
                        mLGA = c.String(maxLength: 70),
                        mEmail = c.String(maxLength: 250),
                        mPhoneNo1 = c.String(maxLength: 14),
                        mPhoneNo2 = c.String(maxLength: 14),
                        mAnniversaryDate = c.DateTime(nullable: false),
                        mSpoueAttending = c.Boolean(nullable: false),
                        mSpouseName = c.String(maxLength: 150),
                        mSpouseDOB = c.String(),
                        mSpouseEmail = c.String(maxLength: 250),
                        mEmployerName = c.String(maxLength: 250),
                        mEmployerAddress = c.String(maxLength: 350),
                        mProfession = c.String(maxLength: 50),
                        mOccupation = c.String(maxLength: 50),
                        mSpouseProfession = c.String(maxLength: 50),
                        mSpouseOccupation = c.String(maxLength: 50),
                        mAltarCall = c.Boolean(nullable: false),
                        mDateJoinedCC = c.DateTime(nullable: false),
                        mAltarCallDate = c.DateTime(nullable: false),
                        mAltarCallChurch = c.String(maxLength: 50),
                        mBaptized = c.Boolean(nullable: false),
                        mBaptismalType = c.String(maxLength: 50),
                        mGift = c.Boolean(nullable: false),
                        mSpousePhone1 = c.String(maxLength: 14),
                        mSpousePhone2 = c.String(maxLength: 14),
                        mWorker = c.Boolean(nullable: false),
                        mDept = c.String(maxLength: 50),
                        mAreaOfInterest = c.String(maxLength: 150),
                        mSuggestion = c.String(maxLength: 350),
                    })
                .PrimaryKey(t => t.MemberID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
        }
    }
}
