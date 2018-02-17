using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Community.Models;

namespace Community.Controllers
{
    public class NewDonationController : Controller
    {
        CommunityAssist2017Entities db = new CommunityAssist2017Entities();
        // GET: NewDonation

        public ActionResult Index()
        {
            if (Session["reistrationKey"] == null)
            {
                Class1Messages m = new Class1Messages();
                m.MessageText = "login required to donate.";
                return RedirectToAction("Result", m);
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "DonationAmount")] NewDonation nd)
        {
            int rKey = (int)Session["ReviewerKey"];

            Donation d = new Donation();
            d.DonationAmount = nd.DonationAmount;
            d.DonationDate = DateTime.Now;
            d.PersonKey = rKey;
            d.DonationConfirmationCode = Guid.NewGuid();

            db.Donations.Add(d);
            db.SaveChanges();

            Class1Messages m = new Class1Messages();
            m.MessageText = "Thanks for the Donation";

            return View("Result", m);
        }

        public ActionResult Result(Class1Messages m)
        {
            return View(m);
        }
    }
}

