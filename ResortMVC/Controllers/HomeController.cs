using ResortMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResortMVC.Controllers
{
    public class HomeController : Controller
    {
        ResortEntityEntities obj = new ResortEntityEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        [HttpPost]
        public ActionResult SendMsg(Feedback log)
        {
            //object of the feed back class that is used to passs  the record in the table by using the class of the controller or model class and using the getter setter method of the class
            Feedback obj_Feed = new Feedback();
            //passin the query to the controller of the main class that is used to insert the reocrd
            String query = "insert into Contact (Name,Email,Contact,Message) values('" + log.Name + "','" + log.Email + "','" + log.contact + "','" + log.Msg + "')";
            //calling the method of the model class
            obj_Feed.sendfeedback(query);
            //redirecting the user to the feed back page after giving the feed back to the user 
            return View("Result");


        }


        public ActionResult allFeedBack()
        {
           
            return View(obj.Contacts.ToList());
        }

        // GET: Order/Delete/5
        public ActionResult Delete(Contact IdToDelete)
        {

            var d = obj.Contacts.Where(x => x.id == IdToDelete.id).FirstOrDefault();
            obj.Contacts.Remove(d);
            obj.SaveChanges();
            return RedirectToAction("allFeedBack");
        }

        public ActionResult Result()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



    }
}