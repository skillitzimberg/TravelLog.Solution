using System.Collections.Generic;

namespace TravelLog.Models
{
  public class Place
  {
    private string _cityName;
    private string _journalEntry;
    private static List<Place> _locations = new List<Place> {};

    public Place (string cityName, string journalEntry)
    {
      _cityName = cityName;
      _journalEntry = journalEntry;
      _locations.Add(this);
    }

    public static List<Place> GetAll()
    {
      return _locations;
    }

    public string GetCityName()
    {
      return _cityName;
    }

    public void SetCityName(string cityName)
    {
      _cityName = cityName;
    }

    public string GetJournalEntry()
    {
      return _journalEntry;
    }

    public void SetJournalEntry(string journalEntry)
    {
      _journalEntry = journalEntry;
    }
  }
}
