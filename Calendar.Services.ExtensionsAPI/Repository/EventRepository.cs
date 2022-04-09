using AutoMapper;
using Calendar.Services.ExtensionsAPI.DbContexts;
using Calendar.Services.ExtensionsAPI.Models;
using Calendar.Services.ExtensionsAPI.Models.Dto;

namespace Calendar.Services.ExtensionsAPI.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly AppDbContext _db;
        private IMapper _mapper;


        public EventRepository(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        public async Task<IEnumerable<EventDto>> GetEvents()
        {
            List<Event> eventList = await _db.Events.ToListAsync();
            return _mapper.Map<List<EventDto>>(eventList);
        }

        public async Task<EventDto> GetEventById(int eventId)
        {
            Event eventt = await _db.Events.Where(x => x.EventId == eventId).FirstOrDefaultAsync();
            return _mapper.Map<EventDto>(eventt);
        }

        public async Task<EventDto> CreateUpadteEvent(EventDto eventDto)
        {
            Event eventt = _mapper.Map<EventDto, Event>(eventDto);

            if (eventt.EventId > 0)
            {
                _db.Events.Update(eventt);
            }
            else
            {
                _db.Events.Add(eventt);
            }

            await _db.SaveChangesAsync();
            return _mapper.Map<Event, EventDto>(eventt);
        }

        public async Task<bool> DeleteEvent(int eventId)
        {
            try
            {
                Event eventt = await _db.Events.FirstOrDefaultAsync(u => u.EventId == eventId);

                if (eventt == null)
                {
                    return false;
                }

                _db.Events.Remove(eventt);
                await _db.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
