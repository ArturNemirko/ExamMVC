using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RaceLibrary;

namespace ExamMVC.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        protected RaceService _service = new RaceService();

        // GET: Admin/Admin
        public ActionResult Index()
        {
            if (Request.Browser.Browser == "InternetExplorer")
                return View("ErrorIE");
            return View();
        }

        public ActionResult Member()
        {
            if (Request.Browser.Browser == "InternetExplorer")
                return View("ErrorIE");
            return View(_service.GetAllParticipants().ToList());
        }

        public ActionResult StartRace()
        {
            if (Request.Browser.Browser == "InternetExplorer")
                return View("ErrorIE");
            return View("Index");
        }

        public ActionResult EditRace(int id, int vote)
        {
            if (Request.Browser.Browser == "InternetExplorer")
                return View("ErrorIE");
            ModelState.Clear();
            _service.ChangeParticipant(id, vote);
            return View("Member", _service.GetAllParticipants().ToList());
        }
    }
}