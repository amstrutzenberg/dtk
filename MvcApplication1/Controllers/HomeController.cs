using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController: Controller
    {
        //
        // GET: /Portal/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Staff(){return View(); }
        public ActionResult Programs() { return View(); }
        public ActionResult History() { return View(); }
        public ActionResult Locations() { return View(); }
        public ActionResult Calendars() { return View(); }
        public ActionResult BeltReqs() { return View(); }
        public ActionResult TrialOffer() { return View(); }
        public ActionResult BlackBeltExam() { return View(); }
        public ActionResult BeltExams() { return View(); }
        public ActionResult Careers() { return View(); }
        public ActionResult Schedules() { return View(); }


	}
}