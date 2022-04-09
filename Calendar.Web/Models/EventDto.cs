namespace Calendar.Web.Models
{
    public class EventDto
    {
        public int EventId { get; set; }
        public string? EventString { get; set; }
        public string? EventImageUrl { get; set; }
        public DateTime EventDateTime { get; set; }
        public double EventDouble { get; set; }
        public int EventInt { get; set; }
    }
}
