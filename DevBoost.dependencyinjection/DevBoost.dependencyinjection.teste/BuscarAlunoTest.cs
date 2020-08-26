using DevBoost.dependencyinjection.Models;
using DevBoost.dependencyinjection.Repository;
using DevBoost.dependencyinjection.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace DevBoost.dependencyinjection.teste
{
    public class BuscarAlunoTest
    {
        private readonly IAlunoService _alunoService;

        public BuscarAlunoTest()
        {
            _alunoService = new AlunoService(new AlunoRepository());
        }

        [Fact]
        public void BuscarAlunoComSucesso()
        {
            IList<Aluno> alunos = _alunoService.GetAll();

            Assert.NotEmpty(alunos);
        }
    }
}
