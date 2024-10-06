using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PC120240219100520CUTIMANCO.DOMAIN.Core.Entities;
using PC120240219100520CUTIMANCO.DOMAIN.Core.Interfaces;

namespace PC120240219100520CUTIMANCO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendesController : ControllerBase
    {
        private readonly IAttendeesRepository _attendeesRepository;

        public AttendesController(IAttendeesRepository attendeesRepository)
        {
            _attendeesRepository = attendeesRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAttendees()
        {
            var attendees = await _attendeesRepository.GetAttendees();
            return Ok(attendees);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAttendees([FromBody]Attendees attendees)
        {
            int id = await _attendeesRepository.Insert(attendees);
            return Ok(id);
        }
    }
}
