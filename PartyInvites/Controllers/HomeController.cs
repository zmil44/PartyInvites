using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string timeOfDay;
            if (hour < 12)
            {
                timeOfDay = "Good Morning";
            }
            else if (hour < 18)
            {
                timeOfDay = "Good Afternoon";
            }
            else
            {
                timeOfDay = "Good Evening";
            }
            ViewBag.Greeting = timeOfDay;
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to the party organizer
                return View("Thanks", guestResponse);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }
 
    }
}