using System.Globalization;
namespace calendar_events;

public class Event : IEvent
{
    public string? Title {get; set; }
    public DateTime EventDate {get; set; }
    public string? Description {get; set; }

    public Event(string title, string date, string description)
    {
        Title = title;
        EventDate = DateTime.Parse(date);
        Description = description;
    }

    public Event(string title, string date)
    {
        Title = title;
        EventDate = DateTime.Parse(date);
    }

    public void DelayDate(int days)
    {
        var duration =  new TimeSpan(days, 0, 0, 0);
        EventDate = EventDate.Add(duration);
    }

    public string PrintEvent(string format)
    {
        if(format == "normal")
        {
            return $"Evento = {Title}\nDate = {EventDate.ToString("dd/MM/yyyy")}\n";
        }
        else
        {
            return $"Evento = {Title}\nDate = {EventDate.ToString("dd/MM/yyyy")}\nDescription = {Description}";
        }
    }
}
