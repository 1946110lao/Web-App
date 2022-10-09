using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBigZuydChallenge.Models;

namespace TheBigZuydChallenge.Controllers
{
    public class UserRegisterController : Controller
    {
        [HttpGet]
        public ActionResult Register()
        {
            User userModel = new User();
            return View(userModel);
        }

        [HttpPost]

        public ActionResult Register(User userModel)
        {
            using (RegisterModel usermodels = new RegisterModel())
            {

                usermodels.Users.Add(userModel);
                usermodels.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccesMessage = "Registratie Compleet";
            return View("Register", new User());
        }
    }
}
