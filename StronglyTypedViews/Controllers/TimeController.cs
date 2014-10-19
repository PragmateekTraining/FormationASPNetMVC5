using StronglyTypedViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedViews.Controllers
{
    public class TimeController : Controller
    {
        // GET: Time
        public ActionResult Index()
        {
            DateTime now = DateTime.Now;

            ViewBag.Year = now.Year;
            ViewBag.Month = now.Month;
            ViewBag.Day = now.Day;

            TimeModel model = new TimeModel
            {
                Year = now.Year,
                Month = now.Month,
                Day = now.Day
            };

            return View(model);
        }
    }
}