using Calendar.Services.ExtensionsAPI.Models.Dto;
using Calendar.Services.ExtensionsAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Calendar.Services.ExtensionsAPI.Controllers
{
    [Route("api/events")]
    public class EventAPIController : ControllerBase
    {
        protected ResponseDto _response;
        private IEventRepository _eventRepository;

        public EventAPIController(IEventRepository productRepository)
        {
            _eventRepository = productRepository;
            this._response = new ResponseDto();
        }


        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<EventDto> eventDtos = await _eventRepository.GetEvents();
                _response.Result = eventDtos;
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { e.ToString() };
            }
            return _response;
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                EventDto eventDto = await _eventRepository.GetEventById(id);
                _response.Result = eventDto;
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { e.ToString() };
            }
            return _response;
        }


        [HttpPost]
        public async Task<object> Post([FromBody] EventDto eventDto)
        {
            try
            {
                EventDto model = await _eventRepository.CreateUpadteEvent(eventDto);
                _response.Result = model;
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { e.ToString() };
            }
            return _response;
        }


        [HttpPut]
        public async Task<object> Put([FromBody] EventDto eventDto)
        {
            try
            {
                EventDto model = await _eventRepository.CreateUpadteEvent(eventDto);
                _response.Result = model;
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { e.ToString() };
            }
            return _response;
        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<object> Delete(int id)
        {
            try
            {
                bool isSuccess = await _eventRepository.DeleteEvent(id);
                _response.Result = isSuccess;
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { e.ToString() };
            }
            return _response;
        }
    }
}
