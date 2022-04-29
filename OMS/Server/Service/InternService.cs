using Microsoft.EntityFrameworkCore;
using OMS.Server.Data;
using OMS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.Server.Service
{
    public class InternService : IInternService
    {
        private readonly DataContext _data;

        public InternService(DataContext data)
        {
            _data = data;
        }


        List<Intern> Interns = new List<Intern>();
        Intern intern = new Intern();

        public async Task<List<Intern>> AddIntern(Intern intern)
        {
            await _data.interns.AddAsync(intern);
            await _data.SaveChangesAsync();
            return Interns = await _data.interns.ToListAsync();
        }

        public async Task<Intern> GetIntern(int internId)
        {
            return intern = await _data.interns.Where(u => u.Id == internId).FirstOrDefaultAsync();
        }

        public async Task<List<Intern>> LoadAllIntern()
        {
            return Interns = await _data.interns.ToListAsync();
        }

        public async Task<List<Intern>> RemoveIntern(Intern intern)
        {
            _data.interns.Remove(intern);
            await _data.SaveChangesAsync();
            Interns = await _data.interns.ToListAsync();
            return Interns;
        }

        public async Task<List<Intern>> UpdateIntern(Intern intern)
        {
            Interns = await _data.interns.ToListAsync();
            var dbIntern = await _data.interns.FindAsync(intern.Id);
            if (dbIntern != null)
            {
                _data.Entry(dbIntern).CurrentValues.SetValues(intern);
                await _data.SaveChangesAsync();
            }
            return Interns;
        }
    }
}
