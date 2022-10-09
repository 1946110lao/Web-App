using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using TheBigZuydChallenge.Models;

namespace TheBigZuydChallenge.Controllers
{
    public class AdminController : Controller
    {


        [Authorize(Users = "AdminUser")]


        public ActionResult Index()
        {
            Review reviewAdventure = new Review();
            return View(reviewAdventure.AdminReviews.ToList());

        }




        [ActionName("Delete")]


        public ActionResult DeleteAdventure(int? id)
        {

            Review review = new Review();

            var Review = review.AdminReviews.Find(id);

            if (Review == null)
            {
                return HttpNotFound();
            }

            review.AdminReviews.Remove(Review);
            review.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet, ActionName("Approve")]

        public ActionResult ApproveAdventure(int? id)
        {
            Review approvedAdventure = new Review();
            var data = approvedAdventure.AdminReviews.ToList();

            foreach (var item in data)
            {
                Adventure adventure = new Adventure();
                {
                    adventure.AdventureId = item.AdminReviewId;
                    adventure.Name = item.Name;
                    adventure.Tag1 = item.Tag1;
                    adventure.Tag2 = item.Tag2;
                    adventure.Tag3 = item.Tag3;
                    adventure.Costs = item.Costs;
                    adventure.IdealTime = item.IdealTime;
                    adventure.Duration = item.Duration;
                    adventure.IdealTime = item.IdealTime;
                    adventure.Size = item.Size;
                    adventure.Description = item.Description;
                }




                MakeAdventure AddAdventure = new MakeAdventure();


                Review DeleteAdventure = new Review();
                var Delete = DeleteAdventure.AdminReviews.Find(id);

                if (Delete == null)
                {
                    return HttpNotFound();
                }
                AddAdventure.Adventures.Add(adventure);
                DeleteAdventure.AdminReviews.Remove(Delete);
                DeleteAdventure.SaveChanges();

                AddAdventure.SaveChanges();
                    
            }
            return RedirectToAction("Index");


        }

    }
}