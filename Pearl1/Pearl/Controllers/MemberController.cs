using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Pearl.Models;

namespace Pearl.Controllers
{
    public class MemberController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Member
        public async Task<ActionResult> Index(string option, string search)
        {
            //if a user choose the radio button option as Subject  
            if (option == "First Name")
            {
                //Index action method will return a view with a student records based on what a user specify the value in textbox  
                return View(db.Members.Where(x => x.mFirstname == search || search == null).ToList());
            }
            else if (option == "Last Name")
            {
                return View(db.Members.Where(x => x.mSurname == search || search == null).ToList());
            }
            else if (option == "E-Mail")
            {
                return View(db.Members.Where(x => x.mEmail == search || search == null).ToList());
            }
            else if (option == "Phone No")
            {
                return View(db.Members.Where(x => x.mPhoneNo1 == search || search == null).ToList());
            }
            else
            {
                return View(await db.Members.ToListAsync());
                //return View(db.Members.Where(x => x.mFirstname.StartsWith(search) || search == null).ToList());
            }

        }

        // GET: Member/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = await db.Members.FindAsync(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // GET: Member/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Member/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MemberID,mTitle,mSurname,mFirstname,mOthername,mGender,mMaritalStatus,mDay,mMonth,mAgeGroup,mAddress,mArea,mNearestBustop,mLGA,mEmail,mPhoneNo1,mPhoneNo2,mAnnivDay,mAnnivMonth,mSpoueAttending,mSpouseName,mSpouseEmail,mEmployerName,mEmployerAddress,mProfession,mSpouseProfession,mAltarCall,mAltarCallChurch,mBaptized,mBaptismalType,mGift,mSpousePhone1,mSpousePhone2,mWorker,mDept,mAreaOfInterest,mSuggestion")] Member member)
        {
            if (ModelState.IsValid)
            {
                db.Members.Add(member);
                await db.SaveChangesAsync();
                //this.TempData["messages"] = "Success!";
                //return RedirectToAction("/Member/Success");
                //ViewBag.Message = "Record Submitted";
                //return RedirectToAction("Home/About");
                // TempData["Success"] = "Member created successfully";

                // return this.Redirect("www.rccgchristchurch.org");
                return this.PartialView("_Success");

            }


            TempData["Success"] = "Member created successfully";
            return View(member);
        }

        // GET: Member/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = await db.Members.FindAsync(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // POST: Member/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MemberID,mTitle,mSurname,mFirstname,mOthername,mGender,mMaritalStatus,mDay,mMonth,mAgeGroup,mAddress,mArea,mNearestBustop,mLGA,mEmail,mPhoneNo1,mPhoneNo2,mAnnivDay,mAnnivMonth,mSpoueAttending,mSpouseName,mSpouseEmail,mEmployerName,mEmployerAddress,mProfession,mSpouseProfession,mAltarCall,mAltarCallChurch,mBaptized,mBaptismalType,mGift,mSpousePhone1,mSpousePhone2,mWorker,mDept,mAreaOfInterest,mSuggestion")] Member member)
        {
            if (ModelState.IsValid)
            {
                db.Entry(member).State = EntityState.Modified;
                await db.SaveChangesAsync();
                this.TempData["messages"] = "Success!";
                //return RedirectToAction("/Member/Success");
                ViewBag.Message = "Record Submitted";
            }
            return View(member);
        }

        // GET: Member/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = await db.Members.FindAsync(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // POST: Member/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Member member = await db.Members.FindAsync(id);
            db.Members.Remove(member);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        // GET: Department
        public ActionResult Dept()
        {
            ChurchEntities myEntities = new ChurchEntities();
            var dept = myEntities.Departments.ToList();
            SelectList list = new SelectList(dept, "DeptId", "DeptName");
            ViewBag.DeptListname = list;
            return View();
        }


    }
    public partial class CS : System.Web.UI.Page
    {
        protected void Save(object sender, EventArgs e)
        {
            //Insert record here.

            //Display success message.
            string message = "Your details have been saved successfully.";
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "')};";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
        }
    }


    }



