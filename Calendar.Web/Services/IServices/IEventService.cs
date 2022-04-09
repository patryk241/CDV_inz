using Calendar.Web.Models;

namespace Calendar.Web.Services.IServices
{
    public interface IEventService
    {
        Task<T> GetAllEventsAsync<T>();
        Task<T> GetEventByIdAsync<T>(int eventId);
        Task<T> CreateEventAsync<T>(EventDto eventDto);
        Task<T> UpdateEventAsync<T>(EventDto eventDto);
        Task<T> DeleteEventAsync<T>(int eventId);
    }
}
