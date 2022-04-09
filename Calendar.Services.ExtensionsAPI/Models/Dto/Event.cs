namespace Calendar.Services.ExtensionsAPI.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string? EventString { get; set; }
        public string? EventImageUrl { get; set; }
        public DateTime EventDateTime { get; set; }
        public double EventDouble { get; set; }
        public int EventInt { get; set; }
    }
}
