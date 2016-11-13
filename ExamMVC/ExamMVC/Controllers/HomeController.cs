using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RaceLibrary;

namespace ExamMVC.Controllers
{
    public class HomeController : Controller
    {
        RaceService _service = new RaceService();
        public ActionResult Index()
        {
            if(Request.Browser.Browser == "InternetExplorer")
                return View("ErrorIE");
            return View(_service.GetAllParticipants().ToList());
        }
    }
}
