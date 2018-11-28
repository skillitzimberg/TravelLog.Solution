using Microsoft.AspNetCore.Mvc;
using TravelLog.Models;

namespace TravelLog.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index() { return View(); }

    }
}
