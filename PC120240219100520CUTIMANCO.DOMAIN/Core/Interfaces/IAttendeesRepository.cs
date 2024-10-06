using PC120240219100520CUTIMANCO.DOMAIN.Core.Entities;

namespace PC120240219100520CUTIMANCO.DOMAIN.Core.Interfaces
{
    public interface IAttendeesRepository
    {
        Task<IEnumerable<Attendees>> GetAttendees();
        Task<int> Insert(Attendees attendees);
    }
}