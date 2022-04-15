using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2_61133209.Controllers
{
    public class Sinhvien_61133209Controller : Controller
    {
        // GET: Sinhvien_61133209
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2(FormCollection field)
        {
            ViewBag.Id = field["Id"];
            ViewBag.Name = field["Name"];
            ViewBag.Marks = field["Marks"];
            return View(ViewBag);

        }
    }
}