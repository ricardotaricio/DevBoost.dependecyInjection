using DevBoost.dependencyinjection.Models;
using DevBoost.dependencyinjection.Repository;
using DevBoost.dependencyinjection.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DevBoost.dependencyinjection.teste
{
    public class BuscarCursoTest
    {
        private readonly ICursoService _cursoService;

        public BuscarCursoTest()
        {
            _cursoService = new CursoService(new CursoRepository());
        }

        [Fact]
        public void BuscarAlunoComSucesso()
        {
            IList<Curso> cursos = _cursoService.GetAll();

            Assert.NotEmpty(cursos);
        }
    }
}
