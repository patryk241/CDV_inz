using Calendar.Web.Models;
using Calendar.Web.Services.IServices;

namespace Calendar.Web.Services
{
    public class EventService : BaseService, IEventService
    {
        private readonly IHttpClientFactory _clientFactory;

        public EventService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> CreateEventAsync<T>(EventDto eventDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = StaticConstants.ApiType.POST,
                Data = eventDto,
                Url = StaticConstants.EventAPIBase + "/api/events",
                AccessToken = ""
            });
        }

        public async Task<T> DeleteEventAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = StaticConstants.ApiType.DELETE,
                Url = StaticConstants.EventAPIBase + "/api/events/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> GetAllEventsAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = StaticConstants.ApiType.GET,
                Url = StaticConstants.EventAPIBase + "/api/events",
                AccessToken = ""
            });
        }

        public async Task<T> GetEventByIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = StaticConstants.ApiType.GET,
                Url = StaticConstants.EventAPIBase + "/api/events/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> UpdateEventAsync<T>(EventDto eventDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = StaticConstants.ApiType.PUT,
                Data = eventDto,
                Url = StaticConstants.EventAPIBase + "/api/events",
                AccessToken = ""
            });
        }
    }
}
