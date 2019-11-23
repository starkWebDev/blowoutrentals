using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
       

        // GET: Contact
        //Create a default method called Index that simply returns a string, through the view, that looks like "Please call Support at 801-555-1212. Thank you!" 
        public ActionResult Index()
        {
            ViewBag.Text = "Please call Support at <strong><u>801-555-1212.</u></strong> Thank you!";
            return View();
        }

        //Create another method called Email that receives 2 parameters: name and email address. 
        //It also returns an html encoded string, to the view, thanking the "name" and saying that the company will send an email to the "email" parameter.
        public ActionResult Email(string name, string email)
        {
            ViewBag.ThanksMsg = $"Thank you, {name}, the company will send an email to {email}/";
            return View();
        }


     
    }
}