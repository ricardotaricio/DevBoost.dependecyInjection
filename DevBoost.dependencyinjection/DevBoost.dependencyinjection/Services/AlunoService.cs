using DevBoost.dependencyinjection.Models;
using DevBoost.dependencyinjection.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.dependencyinjection.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository _alunoRepository)
        {
            this._alunoRepository = _alunoRepository;
        }

        public IList<Aluno> GetAll()
        {
            return _alunoRepository.GetAll();
        }
    }
}
