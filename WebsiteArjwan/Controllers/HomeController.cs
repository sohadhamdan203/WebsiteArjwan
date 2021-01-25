using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteArjwan.Models;

namespace WebsiteArjwan.Controllers
{
    public class HomeController : Controller
    {
        ArjwanTechEntities db = new ArjwanTechEntities();
        public ActionResult Index()
        {
           List<Service> list = db.Services.ToList();
           return View(list);
        }

        public ActionResult About()
        {
           
            return View();
        }

        public ActionResult Contact()
        {
           

            return View();
        }

        public ActionResult Services()
        {
            List<Service> list = db.Services.ToList();
            return View(list);
        }

        public ActionResult Portfoilo()
        {
            List<Portfoilo> lista = db.Portfoiloes.ToList();
            return View(lista);
        }
    }
}