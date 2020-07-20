using ResortMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResortMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }


        // GET: Login
        public ActionResult Pannel()
        {
            return View();
        }

        // GET: Login
        public ActionResult Wrong()
        {
            return View();
        }

        //this method is used to validte the user name or password of the user after verfiying the both the control will  transfer to another page 
        [HttpPost]
        public ActionResult LoginDetails(Login log)
        {

            
            String query = "select * from AdminLogin where LoginID='" + log.Name + "' and LoginPassword='" + log.Password + "'";
            DataTable tbl = new DataTable();
            tbl = log.SrchLogin(query);

            if (tbl.Rows.Count > 0)
            {
                return View("Pannel");
            }
            else
            {
                return View("Wrong");
            }

        }
    }
}