using DogRescue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogRescue.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //calls and renders the index view
        {
            HomeModel model = new HomeModel();
            model.Title = "Rescue all the Dogs!";
            model.Message = "all dogs will come with their shots, fixed, and chipped";
            model.Address1 = "1234 awesome ln";
            model.Address2 = "san antonio, tx 78974";
            model.Phone = "425-555-1234";
            model.email1 = "rescueMe@PNW.com";
            model.email2 = "owner_ceo@company.com";
            return View(model);
        }

        public ActionResult AboutUs() //calls and renders the about us view
        {
            AboutUsModel model = new AboutUsModel();
            model.Title = "About Us";
            model.Message = @"The Shelter Pet Project is the result of a collaborative effort between two leading animal
    welfare groups, the Humane Society of the United States and Maddie’s Fund, and the leading 
    producer of public service advertising (PSA) campaigns, The Ad Council.
    Our goal is to make shelters the first place potential adopters turn when looking to get a 
    new pet, ensuring that all healthy and treatable pets find loving homes. We do this by 
    breaking down misconceptions surrounding shelter pets and celebrating the unique bond between
    every shelter pet and parent.";

            return View(model);
        }

    }
}