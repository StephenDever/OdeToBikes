using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToBikes.Models
{
    public class HomeController : Controller
    {
        OdeToBikesDb _db = new OdeToBikesDb();
        public ActionResult Index(string searchTerm = null)
        {
            var model =
                from m in _db.Manufacturers
                orderby m.Name
                where searchTerm == null || m.Name.StartsWith(searchTerm)
                select new ManufacturerListViewModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    Location = m.Location,
                    CountOfModels = m.Models.Count()
                };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}