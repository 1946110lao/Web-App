

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBigZuydChallenge.Models;

namespace TheBigZuydChallenge.Controllers
{
    public class MakeAdventureController : Controller
    {

        [HttpGet]
        public ActionResult MakeAdventure()
        {
            AdminReview reviewModel = new AdminReview();
            return View(reviewModel);
        }

        [HttpPost]

        public ActionResult MakeAdventure(AdminReview reviewModel)
        {
            using (Review reviewmodels = new Review())
            {

                reviewmodels.AdminReviews.Add(reviewModel);
                reviewmodels.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccesMessage = "Avontuur doorgestuurd";
            return View("MakeAdventure", new AdminReview());
        }

    }
}