using Hackathon.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hackathon.Demo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult Login(LoginModel model)
        {
            if (!string.IsNullOrEmpty(model.UserName) && model.UserName.ToLower() == "jennywon"
                && !string.IsNullOrEmpty(model.Password) && model.Password.ToLower() == "p8p8p8p8")
            {
                return PartialView("PersonalInfo");
            }
            ModelState.AddModelError(string.Empty, "User Id/Password is empty!");
            return PartialView("Login");
        }
    }
}
