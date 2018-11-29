using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using TravelLog.Models;

namespace TravelLog.Tests
{
  [TestClass]
  public class PlaceTests
  {
    // public void Dispose()
    // {
    //   Place.ClearAll();
    // }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Bangkok", "Did a thing.");

      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnCityName_String()
    {
      string expectedJournalEntry = "I arrived in Ho Chi Minh today";
      string expectedCityName = "Ho Chi Minh";
      Place newPlace = new Place(expectedCityName, expectedJournalEntry);

      string actualCityName = newPlace.GetCityName();
      string actualJournalEntry = newPlace.GetJournalEntry();

      Assert.AreEqual(expectedCityName, actualCityName);
      Assert.AreEqual(expectedJournalEntry, actualJournalEntry);
    }

  }

}
