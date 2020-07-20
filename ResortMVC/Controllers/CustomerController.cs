using ResortMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResortMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        ResortEntityEntities obj = new ResortEntityEntities();

        public ActionResult allCustomer()
        {
            return View(obj.Customers.ToList());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customerRegister)
        {
            if (!ModelState.IsValid)
                return View();
            obj.Customers.Add(customerRegister);
            obj.SaveChanges();
            //Response.Redirect("StudentAdmission",true);
            return RedirectToAction("allCustomer");
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {

            var customerToEdit = (from m in obj.Customers where m.id == id select m).First();
            return View(customerToEdit);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(Customer customerToEdit)
        {

            var orignalRecord = (from m in obj.Customers where m.id == customerToEdit.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            obj.Entry(orignalRecord).CurrentValues.SetValues(customerToEdit);

            obj.SaveChanges();
            return RedirectToAction("allCustomer");


        }

        // GET: Customer/Delete/5
        public ActionResult Delete(Customer customerToDelete)
        {

            var d = obj.Customers.Where(x => x.id == customerToDelete.id).FirstOrDefault();
            obj.Customers.Remove(d);
            obj.SaveChanges();
            return RedirectToAction("allCustomer");
        }

        // POST: Customer/Delete/5
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
