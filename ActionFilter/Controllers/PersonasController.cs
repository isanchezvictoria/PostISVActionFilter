using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ActionFilter.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult Index()
        {
            return View();
        }


    }
}
