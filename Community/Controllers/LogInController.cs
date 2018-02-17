using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Community.Models;

namespace Community.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "UserName, Password")]LogInClass lc)
        {
            CommunityAssist2017Entities db = new CommunityAssist2017Entities();
            int loginResult = db.usp_Login(lc.UserName, lc.Password);
            if(loginResult != -1)
            {
                var uid = (from r in db.People
                           where r.PersonFirstName.Equals(lc.UserName)
                           select r.PersonKey).FirstOrDefault();
                int rKey = (int)uid;
                Session ["ReviewerKey"] = rKey;

                Class1Messages msg = new Class1Messages();
                msg.MessageText = "Thank You, "
                + lc.UserName
                + " for login you can donate";
                return RedirectToAction("Result", msg);

            }

            Class1Messages message = new Class1Messages();
            message.MessageText = "invalid Login";
            return View("Result", message);
        }

        public ActionResult Result(Class1Messages msg)
        {
            return View(msg);
        }
    }
}