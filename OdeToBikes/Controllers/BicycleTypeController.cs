using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToBikes.Models
{
    public class BicycleTypeController : Controller
    {
        // GET: BicycleType
        public ActionResult Search(string type)
        {
            // type returns "All" as default value, will eventually return "All" page, once created
            if (type == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // encode user inquory for type
                var message = Server.HtmlEncode(type);
                return Content(message);
            }
        }
    }
}