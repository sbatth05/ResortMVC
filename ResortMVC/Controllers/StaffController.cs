using ResortMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResortMVC.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        ResortEntityEntities obj = new ResortEntityEntities();

        public ActionResult allStaff()
        {
            return View(obj.Staffs.ToList());
        }

        // GET: Staff/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staff/Create
        [HttpPost]
        public ActionResult Create(Staff staffRegister)
        {

            if (!ModelState.IsValid)
                return View();
            obj.Staffs.Add(staffRegister);
            obj.SaveChanges();
            //Response.Redirect("StudentAdmission",true);
            return RedirectToAction("allStaff");
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            var staffToEdit = (from m in obj.Staffs where m.id == id select m).First();
            return View(staffToEdit);
        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(Staff staffToEdit)
        {

            var orignalRecord = (from m in obj.Staffs where m.id == staffToEdit.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            obj.Entry(orignalRecord).CurrentValues.SetValues(staffToEdit);

            obj.SaveChanges();
            return RedirectToAction("allStaff");


        }

        // GET: Staff/Delete/5
        public ActionResult Delete(Staff staffToDelete)
        {

            var d = obj.Staffs.Where(x => x.id == staffToDelete.id).FirstOrDefault();
            obj.Staffs.Remove(d);
            obj.SaveChanges();
            return RedirectToAction("allStaff");
        }

        // POST: Staff/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
