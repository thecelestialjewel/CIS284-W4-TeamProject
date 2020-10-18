using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DogRescue.Models;

namespace DogRescue.Controllers
{
    public class RescueDogsController : Controller
    {
        private RescueDogDbContext db = new RescueDogDbContext();

        // GET: RescueDogs
        public ActionResult Index()
        {
            return View(db.RescueDogs.ToList());
        }

        // GET: RescueDogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RescueDog rescueDog = db.RescueDogs.Find(id);
            if (rescueDog == null)
            {
                return HttpNotFound();
            }
            return View(rescueDog);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
