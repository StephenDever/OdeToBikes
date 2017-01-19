using OdeToBikes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToBikes.Models
{
    public class MModelsController : Controller
    {
        OdeToBikesDb _db = new OdeToBikesDb();
        // GET: Models
        public ActionResult Index([Bind(Prefix="id")] int manufacturerId)
        {
            var manufacturer = _db.Manufacturers.Find(manufacturerId);
            if (manufacturer != null)
            {
                return View(manufacturer);
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create(int manufacturerId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ManufacturerModel model)
        {
            if (ModelState.IsValid)
            {
                // creates a new _db entry
                _db.Models.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = model.ManufacturerId });
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.Models.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(ManufacturerModel model)
        {
            if (ModelState.IsValid)
            {
                // takes a _db entry and sets it to be modifiable 
                _db.Entry(model).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = model.ManufacturerId});
            }
            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
