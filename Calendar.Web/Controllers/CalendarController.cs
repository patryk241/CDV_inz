using Calendar.Web.Models;
using Calendar.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Calendar.Web.Controllers
{
    public class CalendarController : Controller
    {
        private readonly IEventService _eventService;

        public CalendarController(IEventService eventService)
        {
            _eventService = eventService;
        }


        public async Task<IActionResult> Calendar()
        {
            List<EventDto> list = new();
            var response = await _eventService.GetAllEventsAsync<ResponseDto>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<EventDto>>(Convert.ToString(response.Result));
            }

            return View(list);
        }


        public async Task<IActionResult> CalendarEventCreate()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CalendarEventCreate(EventDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _eventService.CreateEventAsync<ResponseDto>(model);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(Calendar));
                }
            }

            return View(model);
        }


        public async Task<IActionResult> CalendarEventEdit(int eventId)
        {
            ResponseDto response = await _eventService.GetEventByIdAsync<ResponseDto>(eventId);
            if (response != null && response.IsSuccess)
            {
                EventDto model = JsonConvert.DeserializeObject<EventDto>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CalendarEventEdit(EventDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _eventService.UpdateEventAsync<ResponseDto>(model);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(Calendar));
                }
            }
            return View(model);
        }


        public async Task<IActionResult> CalendarEventDelete(int eventId)
        {
            ResponseDto response = await _eventService.GetEventByIdAsync<ResponseDto>(eventId);
            if (response != null && response.IsSuccess)
            {
                EventDto model = JsonConvert.DeserializeObject<EventDto>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CalendarEventDelete(EventDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _eventService.DeleteEventAsync<ResponseDto>(model.EventId);
                if (response.IsSuccess)
                {
                    return RedirectToAction(nameof(Calendar));
                }
            }
            return View(model);
        }
    }
}
