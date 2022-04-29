using OMS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.Server.Service
{
    public interface IInternService
    {
        //abstract method of AddUser
        Task<List<Intern>> AddIntern(Intern intern);

        //abstract method of GetUser
        Task<Intern> GetIntern(int internId);

        //abstract method of UpdateUser
        Task<List<Intern>> UpdateIntern(Intern intern);

        //abstract method of RemoveUser
        Task<List<Intern>> RemoveIntern(Intern intern);

        //abstract method of LoadAllStudents
        Task<List<Intern>> LoadAllIntern();
    }
}
