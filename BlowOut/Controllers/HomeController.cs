using BlowOut.DAL;
using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Checkpoint 3, Blowout instrument website
//Cherileigh Leavitt, Ben Jenks, Jared Stark, Anna Yardley

//TODO:
// validate zip is 5 digits
// validate phone is in (xxx) xxx-xxxx formate
// validate email has an @ sign
// About page with history and vision of company - make up something good, and picture of founder (someone clever)
// make sure all links and buttons work properly (ie back to list etc)
// add styling to rentals view so that it looks nice and shows a picture for each product
// add image to summary view for that instrument

namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        public BlowOutContext db = new BlowOutContext();
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

        public ActionResult Rentals()
        {
            List<Instrument> stuff = db.Instruments.ToList<Instrument>();
            ViewBag.Instruments = stuff;
            
            foreach (var item in stuff)
            {
                ViewBag.Instruments += "<div class='col-sm-4' style='padding: 10px; font-family: Bahnschrift;'>";
                ViewBag.Instruments += "<h4>" + item.InstrumentDesc + "</h4>";
                ViewBag.Instruments += "<a href='/Home/Create?ID=" + item.InstrumentID + "'><img src='/Content/images/" + item.InstrumentDesc.ToLower() + ".jpg' style='height: 200px;'/></a>";
                ViewBag.Instruments += "</div>";
            }

            return View();
        }

        public ActionResult RentInstrument(string type)
        {
            return View();
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClientID,Client_FirstName,Client_LastName,Client_StreetAddress,Client_City,Client_State,Client_Zipcode,Client_Email,Client_Phone")] Client client, int ID)
        {
            if (ModelState.IsValid)
            {
                db.Client.Add(client);
                db.SaveChanges();

                Instrument oInstrument = db.Instruments.Find(ID);

                oInstrument.ClientID = client.ClientID;
                db.SaveChanges();

                return RedirectToAction("Summary", new { ClientID = client.ClientID, InstrumentID = oInstrument.InstrumentID });
            }

            return View(client);
        }


        public ActionResult Summary(int clientID, int instrumentID)
        {
            Instrument inst = db.Instruments.Find(instrumentID);
            Client cli = db.Client.Find(clientID);

            ViewBag.Instrument = inst;
            ViewBag.Client = cli;
            ViewBag.MonthlyPrice = Math.Round((inst.InstrumentPrice), 2);
            ViewBag.TotalPrice = Math.Round((inst.InstrumentPrice * 18), 2);
            return View(inst);
        }

    }
}