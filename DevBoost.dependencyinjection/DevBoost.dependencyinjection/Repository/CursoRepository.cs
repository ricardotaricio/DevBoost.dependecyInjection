using DevBoost.dependencyinjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.dependencyinjection.Repository
{
    public class CursoRepository : ICursoRepository
    {
        public IList<Curso> GetAll()
        {
            IList<Curso> cursos = new List<Curso>();

            cursos.Add(new Curso() { Id = 1, Nome = "Dev C#", CargaHoraria = 32 });
            cursos.Add(new Curso() { Id = 2, Nome = "Dev JS", CargaHoraria = 32 });

            return cursos;
        }
    }
}
