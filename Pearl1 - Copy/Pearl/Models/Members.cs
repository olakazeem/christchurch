using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pearl.Models
{
    [Table("Members")]
    public class Member
    {
        [Key]
        
        public int MemberID { get; set; }
        [Display(Name = "Title"), Required]
        [StringLength(10)]
        public string mTitle { get; set; }
        [Display(Name = "Last Name"), Required]
        [StringLength(150)]
        public string mSurname { get; set; }
        [Display(Name = "First Name"), Required]
        [StringLength(150)]
        public string mFirstname { get; set; }
        [Display(Name = "Other Name"), Required]
        [StringLength(150)]
        public string mOthername { get; set; }
        [Display(Name = "Gender"), Required]
        [StringLength(6)]
        public string mGender { get; set; }
        [Display(Name = "Marital Status"), Required]
        [StringLength(10)]
        public string mMaritalStatus { get; set; }
        [Display(Name = "Birthday"), Required]
        public DateTime mBirthday { get; set; }
        [Display(Name = "House Address"), Required]
        [StringLength(350)]
        public string mAddress { get; set; }
        [Display(Name = "Address Area"), Required]
        [StringLength(100)]
        public string mArea { get; set; }
        [Display(Name = "Nearest Bustop"), Required]
        [StringLength(100)]
        public string mNearestBustop { get; set; }
        [Display(Name = "Local Govt"), Required]
        [StringLength(70)]
        public string mLGA { get; set; }
        [Display(Name = "E-Mail"), Required]
        [StringLength(250)]
        public string mEmail { get; set; }
        [Display(Name = "Phone 1"), Required]
        [StringLength(14)]
        public string mPhoneNo1 { get; set; }
        [Display(Name = "Phone 2")]
        [StringLength(14)]
        public string mPhoneNo2 { get; set; }
        [Display(Name = "Wedding Anniverssary")]
        public DateTime mAnniversaryDate { get; set; }
        [Display(Name = "Spouse Attending CC?")]
        public bool mSpoueAttending { get; set; }
        [Display(Name = "Spouse Name"), Required]
        [StringLength(150)]
        public string mSpouseName { get; set; }
        [Display(Name = "Spouse Birthday"), Required]
        public string mSpouseDOB { get; set; }
        [Display(Name = "Spouse EMail"), Required]
        [StringLength(250)]
        public string mSpouseEmail { get; set; }
        [Display(Name = "Employer Name")]
        [StringLength(250)]
        public string mEmployerName { get; set; }
        [Display(Name = "Employer Address")]
        [StringLength(350)]
        public string mEmployerAddress { get; set; }
        [Display(Name = "Profession")]
        [StringLength(50)]
        public string mProfession { get; set; }
        [Display(Name = "Occupation")]
        [StringLength(50)]
        public string mOccupation { get; set; }
        [Display(Name = "Spouse Profession")]
        [StringLength(50)]
        public string mSpouseProfession { get; set; }
        [Display(Name = "Spouse Occupation")]
        [StringLength(50)]
        public string mSpouseOccupation { get; set; }
        [Display(Name = "Responded to Altar Call?")]
        public bool mAltarCall { get; set; }
        [Display(Name = "Date Joined Christ Church"), Required]
        public DateTime mDateJoinedCC { get; set; }
        [Display(Name = "Altar Call Date"), Required]
        public DateTime mAltarCallDate { get; set; }
        [Display(Name = "Church Where you responded to Altar Call"), Required]
        [StringLength(50)]
        public string mAltarCallChurch { get; set; }
        [Display(Name = "Baptized?")]
        public bool mBaptized { get; set; }
        [Display(Name = "Baptismal Type")]
        [StringLength(50)]
        public string mBaptismalType { get; set; }
        [Display(Name = "Are you endowed with Spiritual Gift(s)")]
        public bool mGift { get; set; }
        [Display(Name = "Spouse Phone 1")]
        [StringLength(14)]
        public string mSpousePhone1 { get; set; }
        [Display(Name = "Spouse Phone 2")]
        [StringLength(14)]
        public string mSpousePhone2 { get; set; }
        [Display(Name = "Are you a worker?")]
        public bool mWorker { get; set; }
        [Display(Name = "Department"), Required]
        [StringLength(50)]
        public string mDept { get; set; }
        [Display(Name = "Areas of Interest"), Required]
        [StringLength(150)]
        public string mAreaOfInterest { get; set; }
        [Display(Name = "Suggestion"), Required]
        [StringLength(350)]
        public string mSuggestion { get; set; }
        

    }
}