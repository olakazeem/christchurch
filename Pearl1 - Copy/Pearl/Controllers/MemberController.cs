﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pearl.Models;

namespace Pearl.Controllers
{
    public class MemberController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Member
        public async Task<ActionResult> Index()
        {
            return View(await db.Members.ToListAsync());
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
        public async Task<ActionResult> Create([Bind(Include = "MemberID,mTitle,mSurname,mFirstname,mOthername,mGender,mMaritalStatus,mBirthday,mAddress,mArea,mNearestBustop,mLGA,mEmail,mPhoneNo1,mPhoneNo2,mAnniversaryDate,mSpoueAttending,mSpouseName,mSpouseDOB,mSpouseEmail,mEmployerName,mEmployerAddress,mProfession,mOccupation,mSpouseProfession,mSpouseOccupation,mAltarCall,mDateJoinedCC,mAltarCallDate,mAltarCallChurch,mBaptized,mBaptismalType,mGift,mSpousePhone1,mSpousePhone2,mWorker,mDept,mAreaOfInterest,mSuggestion")] Member member)
        {
            if (ModelState.IsValid)
            {
                db.Members.Add(member);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

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
        public async Task<ActionResult> Edit([Bind(Include = "MemberID,mTitle,mSurname,mFirstname,mOthername,mGender,mMaritalStatus,mBirthday,mAddress,mArea,mNearestBustop,mLGA,mEmail,mPhoneNo1,mPhoneNo2,mAnniversaryDate,mSpoueAttending,mSpouseName,mSpouseDOB,mSpouseEmail,mEmployerName,mEmployerAddress,mProfession,mOccupation,mSpouseProfession,mSpouseOccupation,mAltarCall,mDateJoinedCC,mAltarCallDate,mAltarCallChurch,mBaptized,mBaptismalType,mGift,mSpousePhone1,mSpousePhone2,mWorker,mDept,mAreaOfInterest,mSuggestion")] Member member)
        {
            if (ModelState.IsValid)
            {
                db.Entry(member).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
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
    }
}