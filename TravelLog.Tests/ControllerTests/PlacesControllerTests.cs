using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TravelLog.Controllers;
using TravelLog.Models;

namespace TravelLog.Tests
{
  [TestClass]
  public class PlacesControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      PlacesController controller = new PlacesController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
        //Arrange
      PlacesController controller = new PlacesController();

      //Act
      ActionResult newView = controller.New();

      //Assert
      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }

    // View Datatype Test
    [TestMethod]
    public void Create_ReturnCorrectActionType_RedirectToActionResult()
    {
      //Arrange
      PlacesController controller = new PlacesController();

      //Act
      IActionResult view = controller.Create("A place", "An activity");

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    // Action Name Test
    [TestMethod]
    public void Create_ReturnCorrectActionName_Index()
    {
      //Arrange
      PlacesController controller = new PlacesController();
      RedirectToActionResult actionResult = controller.Create("Bangkok", "Eat.") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;
      //Assert
      Assert.AreEqual(result, "Index");
    }

    // Model Datatype Test
    [TestMethod]
    public void Index_HasCorrectModelType_PlaceList()
    {
      ViewResult indexView = new PlacesController().Index() as ViewResult;

      var result = indexView.ViewData.Model;

      Assert.IsInstanceOfType(result, typeof(List<Place>));

    }

  }
}
