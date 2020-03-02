using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test2.Models;
using Test2.Services;

namespace Test2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Display()
        {

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        static List<UserController> userslist = new List<UserController>();
        [HttpPost]
        public ActionResult Display(ViewModels.ViewModelUser user)
        {
            UserService.Display(user);
            return RedirectToAction("Index");
        }



    }
}