using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

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

        [Display(Name = "Other Name")]
        [StringLength(150)]
        public string mOthername { get; set; }

        [Display(Name = "Gender"), Required]
        [StringLength(6)]
        public string mGender { get; set; }

        [Display(Name = "Marital Status"), Required]
        [StringLength(10)]
        public string mMaritalStatus { get; set; }        

        [Display(Name = "Birth Day")]
        [StringLength(3)]
        public string mDay { get; set; }

        [Display(Name = "Birth Month")]
        [StringLength(4)]
        public string mMonth { get; set; }

        [Display(Name = "Age Bracket")]
        [StringLength(10)]
        public string mAgeGroup { get; set; }

        [Display(Name = "House Address"), Required]
        [StringLength(350)]
        public string mAddress { get; set; }

        [Display(Name = "Address Area"), Required]
        [StringLength(100)]
        public string mArea { get; set; }

        [Display(Name = "Nearest Bus Stop"), Required]
        [StringLength(100)]
        public string mNearestBustop { get; set; }

        [Display(Name = "Local Govt")]
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

        [Display(Name = "Anniversary Day")]
        [StringLength(3)]
        public string mAnnivDay { get; set; }

        [Display(Name = "Anniversary Month")]
        [StringLength(4)]
        public string mAnnivMonth { get; set; }

        [Display(Name = "Spouse Attending CC?")]
        [StringLength(3)]
        public string mSpoueAttending { get; set; }

        [Display(Name = "Spouse Name")]
        [StringLength(150)]
        public string mSpouseName { get; set; }        

        [Display(Name = "Spouse EMail")]
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

        [Display(Name = "Spouse Profession")]
        [StringLength(50)]
        public string mSpouseProfession { get; set; }        

        [Display(Name = "Responded to Altar Call?")]
        [StringLength(3)]
        public string mAltarCall { get; set; }        
        
        [Display(Name = "Department 2")]
        [StringLength(50)]
        public string mAltarCallChurch { get; set; }       

        [Display(Name = "Baptismal Type")]
        [StringLength(50)]
        public string mBaptismalType { get; set; }

        [Display(Name = "Are you endowed with Spiritual Gift(s)")]
        [StringLength(3)]
        public string mGift { get; set; }

        [Display(Name = "Spouse Phone 1")]
        [StringLength(14)]
        public string mSpousePhone1 { get; set; }

        [Display(Name = "Spouse Phone 2")]
        [StringLength(14)]
        public string mSpousePhone2 { get; set; }

        [Display(Name = "Are you a worker?")]
        [StringLength(3)]
        public string mWorker { get; set; }

        [Display(Name = "Department")]
        [StringLength(50)]
        public string mDept { get; set; }
        

        [Display(Name = "Areas of Interest")]
        [StringLength(150)]
        public string mAreaOfInterest { get; set; }

        [Display(Name = "Suggestion")]
        [StringLength(350)]
        public string mSuggestion { get; set; }
        

    }
    public static class MyAlerts
    {
        public const string SUCCESS = "success";
        public const string ATTENTION = "attention";
        public const string ERROR = "error";
        public const string INFORMATION = "info";

        public static string[] ALL
        {
            get
            {
                return new[]
                           {
                           SUCCESS,
                           ATTENTION,
                           INFORMATION,
                           ERROR
                       };
            }
        }

    }
}
