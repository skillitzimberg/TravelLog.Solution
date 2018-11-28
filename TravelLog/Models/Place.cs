using System.Collections.Generic;

namespace TravelLog.Models
{
  public class Place
  {
    private string _cityName;
    private string _journalEntry;

    public Place (string cityName, string journalEntry)
    {
      _cityName = cityName;
      _journalEntry = journalEntry;
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
