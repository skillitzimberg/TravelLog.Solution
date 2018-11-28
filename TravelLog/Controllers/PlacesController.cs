using Microsoft.AspNetCore.Mvc;
using TravelLog.Models;

namespace TravelLog.Controllers
{
    public class PlacesController : Controller
    {
        [HttpPost("/places/new")]
        public ActionResult Index()
        {
          return View();
        }

    }
}
