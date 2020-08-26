using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevBoost.dependencyinjection.Models;
using DevBoost.dependencyinjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevBoost.dependencyinjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _alunoService.GetAll();
        }
    }
}
