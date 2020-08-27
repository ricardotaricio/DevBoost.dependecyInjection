using DevBoost.dependencyinjection.Models;
using DevBoost.dependencyinjection.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.dependencyinjection.Services
{
    public class CursoService : ICursoService
    {
        private readonly ICursoRepository _cursoRepository;

        public CursoService(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public IList<Curso> GetAll()
        {
            return _cursoRepository.GetAll();
        }
    }
}
