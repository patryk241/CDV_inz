using Calendar.Services.ExtensionsAPI.Models.Dto;
using System.Threading.Tasks;

namespace Calendar.Services.ExtensionsAPI.Repository
{
    public interface IEventRepository
    {
        Task<IEnumerable<EventDto>> GetEvents();
        Task<EventDto> GetEventById(int eventId);
        Task<EventDto> CreateUpadteEvent(EventDto eventDto);
        Task<bool> DeleteEvent(int eventId);

    }
}
