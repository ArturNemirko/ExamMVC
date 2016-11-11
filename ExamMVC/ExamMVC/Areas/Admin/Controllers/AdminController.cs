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
            return View();
        }

        public ActionResult Member()
        {
            return View(_service.GetAllParticipants().ToList());
        }

        public ActionResult StartRace()
        {
            return View("Index");
        }

        public ActionResult EditRace(int id, int vote)
        {
            ModelState.Clear();
            _service.ChangeParticipant(id, vote);
            return View("Member", _service.GetAllParticipants().ToList());
        }
    }
}