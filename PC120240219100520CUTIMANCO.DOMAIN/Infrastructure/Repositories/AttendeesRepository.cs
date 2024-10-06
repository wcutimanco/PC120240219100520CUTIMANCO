using Microsoft.EntityFrameworkCore;
using PC120240219100520CUTIMANCO.DOMAIN.Core.Entities;
using PC120240219100520CUTIMANCO.DOMAIN.Core.Interfaces;
using PC120240219100520CUTIMANCO.DOMAIN.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC120240219100520CUTIMANCO.DOMAIN.Infrastructure.Repositories
{
    public class AttendeesRepository : IAttendeesRepository
    {
        private readonly EventManagementDbContext _dbContext;

        public AttendeesRepository(EventManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Attendees>> GetAttendees()
        {
            var arttend = await _dbContext.Attendees.ToListAsync();
            return arttend;
        }
        public async Task<int> Insert(Attendees attendees)
        {
            await _dbContext.Attendees.AddAsync(attendees);
            int rows = await _dbContext.SaveChangesAsync();
            return rows;
        }

    }
}
