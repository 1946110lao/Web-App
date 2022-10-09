using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using TheBigZuydChallenge.Models;


namespace TheBigZuydChallenge.Controllers
{
    public class FindAdventureController : Controller
    {

        // GET: FindAdventure

       public class GlobalVariable
        {
            public int ConfirmValue { get; set; }

          
 
        }


        GlobalVariable confirm = new GlobalVariable();
        MakeAdventure AdventureList = new MakeAdventure();

        public ActionResult Adventures()
        {
          
            return View(AdventureList.Adventures.ToList());
        }

        public ActionResult ChooseAdventure()
        {


            if ( confirm.ConfirmValue == 0)
            {
      
                List<string> adventureList = new List<string>();
                Adventure listitems = new Adventure();
                adventureList.Add(listitems.Name);
                adventureList.Add(listitems.Tag1);
                adventureList.Add(listitems.Tag2);
                adventureList.Add(listitems.Tag3);
                adventureList.Add(listitems.Costs);
                adventureList.Add(listitems.IdealTime);
                adventureList.Add(listitems.Duration);
                adventureList.Add(listitems.Size);
                adventureList.Add(listitems.Description);

                confirm.ConfirmValue = confirm.ConfirmValue + 1;

                
                return RedirectToAction("Main", "Login");
            }

            else if (confirm.ConfirmValue >= 1)
                {
                    ModelState.AddModelError("", "Je hebt al een avontuur gekozen");
                System.Diagnostics.Debug.WriteLine("Reached confirm >= statement");
                return RedirectToAction("Index", "Home");
                }
            else
            {
                ModelState.AddModelError("", "Er is een fout opgetreden");
            }


            return View();
        }

        [HttpGet]
        public ActionResult Index(string searching)
        {
            using (MakeAdventure nameSearch = new MakeAdventure())
            {

                if (!String.IsNullOrEmpty(searching))
                {
                    var NameSearch = nameSearch.Adventures.Where(x => x.Name.Contains(searching) || searching == null).ToList();
                }
                
                return RedirectToAction("Adventures");
            }
  

        }
    
        
    }

   

}