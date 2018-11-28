using Microsoft.AspNetCore.Mvc;
using TravelLog.Models;
using System.Collections.Generic;

namespace TravelLog.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string journalEntry)
    {
      Place newPlace = new Place(cityName, journalEntry);
      return RedirectToAction("Index");
    }
  }
}
