using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OMS.Server.Service;
using OMS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternController : ControllerBase
    {
        private readonly IInternService _internService;

        public InternController(IInternService internService)
        {
            _internService = internService;
        }

        List<Intern> Users = new List<Intern>();
        Intern user = new Intern();

        [HttpPost("create")]
        public async Task<ActionResult<List<Intern>>> LoginIntern(Intern intern)
        {
            return Users = await _internService.AddIntern(intern);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<Intern>>> UpdateIntern(Intern intern)
        {
            return Users = await _internService.UpdateIntern(intern);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Intern>>> DeleteIntern(Intern intern)
        {
            return Users = await _internService.RemoveIntern(intern);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<Intern>>> GetAllStudent()
        {
            return Users = await _internService.LoadAllIntern();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<Intern>> GetAllStudent(int Id)
        {
            return user = await _internService.GetIntern(Id);
        }
    }
}
