using DevBoost.dependencyinjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.dependencyinjection.Repository
{
    public interface IAlunoRepository
    {
        public IList<Aluno> GetAll();
    }
}
