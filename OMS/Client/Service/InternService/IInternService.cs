using OMS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.Client.Service.InternService
{
    interface IInternService
    {
        Task<List<Intern>> AddIntern(Intern intern);

        Task<List<Intern>> UpdateIntern(Intern intern);

        Task<List<Intern>> DeleteIntern(Intern intern);

        Task<List<Intern>> GetAllIntern();

        Task<Intern> GetIntern(int Id);
    }
}
