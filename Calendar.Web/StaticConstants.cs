namespace Calendar.Web
{
    public class StaticConstants
    {
        public static string EventAPIBase { get; set; }
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
