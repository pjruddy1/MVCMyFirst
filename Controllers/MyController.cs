using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMyFirst.Controllers
{
    public class MyController : Controller
    {
        
        // GET: My
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string selection)
        {
            var selectedItem = HttpUtility.HtmlEncode(selection);
            var viewName = "";
            switch (selectedItem)
            {
                case "Kiteboarding":
                    viewName = "Kiteboarding";
                    break;
                case "Jogging":
                    viewName = "Jogging";
                    break;
                case "Coding":
                    viewName = "Coding";
                    break;
                default:
                    viewName = "Index";
                    break;
            }
            return View(viewName);
        }

        public ActionResult YourFavForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YourFavForm(string name, bool shareable, int hours)
        {
            if (name == "")
            {
                ViewBag.message = "You forgot to type in the activity name, but thank you for taking the time to share.";
            }
            else if (shareable && name != "")
            {
                ViewBag.message = "Thank you for informing me about " + name;
                if (hours < 50)
                {
                    ViewBag.message += ". It sounds like your just getting started in this activity.  I hope you keep enjoying " + name + ".";
                }
                else
                {
                    ViewBag.message += ". It sounds like you have been doing it a while.";
                }
            }
            else
            {
                ViewBag.message = "Thank you for filling out the form.  I won't share your favortie activity.";
            }
            return View("ThankYou");
        }
    }
}