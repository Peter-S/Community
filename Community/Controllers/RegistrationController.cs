using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Community.Models;
 
namespace Community.Controllers
{
    public class RegistrationController : Controller
    {

        CommunityAssist2017Entities db = new CommunityAssist2017Entities();
        // GET: Registration
        

        public ActionResult Index()
        {
            return View(db.People.ToList());
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Result(Class1Messages m)
        {
            return View(m);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "lastname, firstname, email, password, " +
            "apartmentNumbr, street, city, state, zipcode, phone")]NewPerson R)

        {
            int result = db.usp_Register(
                R.lastname,
                R.firstname,
                R.email,
                R.password,
                R.apartmentNumber,
                R.street,
                R.city,
                R.state,
                R.zipcode,
                R.phone);

            Class1Messages m = new Class1Messages();
            if(result != -1)

            {
                m.MessageText = "thanks for registering";
                return RedirectToAction("Result",m);
            }

            m.MessageText = "opps, try again";
            return RedirectToAction("Result", m);
        }

    }
}