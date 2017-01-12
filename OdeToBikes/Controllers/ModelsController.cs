using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToBikes.Controllers
{
    public class ModelsController : Controller
    {
        // GET: Models
        public ActionResult Index()
        {
            var model =
                from m in _models
                orderby m.Year descending
                select m;

            return View(model);
        }

        // GET: Models/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Models/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Models/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Models/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Models/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Models/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Models/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<ManufacturerModel> _models = new List<ManufacturerModel>
        {
            new ManufacturerModel
            {
                Id =1,
                Manufacturer = "Specialized",
                Model = "Sirrus",
                Year = 1991,
                Info = ""
            },
            new ManufacturerModel
            {
                Id =2,
                Manufacturer = "Miyata",
                Model = "912",
                Year = 1981,
                Info = ""
            },
            new ManufacturerModel
            {
                Id =3,
                Manufacturer = "Nishiki",
                Model = "Prestige",
                Year = 1986,
                Info = ""
            }
        };
    }

}
