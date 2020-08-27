using DevBoost.dependencyinjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.dependencyinjection.Services
{
    public interface ICursoService
    {
        public IList<Curso> GetAll();
    }
}
