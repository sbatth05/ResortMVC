using ResortMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResortMVC.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        ResortEntityEntities obj = new ResortEntityEntities();

        public ActionResult allPayment()
        {
            return View(obj.Payments.ToList());
        }

        // GET: Payment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Payment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Payment/Create
        [HttpPost]
        public ActionResult Create(Payment paymentToAdd)
        {
            if (!ModelState.IsValid)
                return View();
            obj.Payments.Add(paymentToAdd);
            obj.SaveChanges();
            //Response.Redirect("StudentAdmission",true);
            return RedirectToAction("allPayment");
        }

        // GET: Payment/Edit/5
        public ActionResult Edit(int id)
        {

            var paymentToEdit = (from m in obj.Payments where m.id == id select m).First();
            return View(paymentToEdit);
        }

        // POST: Payment/Edit/5
        [HttpPost]
        public ActionResult Edit(Payment paymentToEdit)
        {

            var orignalRecord = (from m in obj.Payments where m.id == paymentToEdit.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            obj.Entry(orignalRecord).CurrentValues.SetValues(paymentToEdit);

            obj.SaveChanges();
            return RedirectToAction("allPayment");

        }

        // GET: Payment/Delete/5
        public ActionResult Delete(Payment paymentToDelete)
        {


            var d = obj.Payments.Where(x => x.id == paymentToDelete.id).FirstOrDefault();
            obj.Payments.Remove(d);
            obj.SaveChanges();
            return RedirectToAction("allPayment");
        }

        // POST: Payment/Delete/5
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
