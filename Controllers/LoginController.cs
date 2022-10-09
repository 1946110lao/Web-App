using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace TheBigZuydChallenge.Models
{
    public class LoginController : Controller
    {
        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Main()
        {
            return View();
        }
       

        [HttpPost]



        public ActionResult Form(User objUser)
        {
            using (RegisterModel login = new RegisterModel())
            {
                bool userexits = login.Users.Any(x => x.Username == objUser.Username && x.Password == objUser.Password);
                User u = login.Users.FirstOrDefault(x => x.Username == objUser.Username && x.Password == objUser.Password);


                if (userexits)
                {
                    FormsAuthentication.SetAuthCookie(u.Username, false);
                    return RedirectToAction("Main", "Login");
                }

                ModelState.AddModelError("", "Gebruikersnaam of wachtwoord komt niet overeen");

                return View();
            }

        }

       

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Form");
        }
        

    }
}