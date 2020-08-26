using DevBoost.dependencyinjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.dependencyinjection.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        public IList<Aluno> GetAll()
        {
            IList<Aluno> alunos = new List<Aluno>();

            Aluno aluno = new Aluno();
            aluno.Id = 1;
            aluno.Nome = "Joaquim Xavier";
            aluno.CPF = "12345678901";
            aluno.DataNascimento = new DateTime(1990, 1, 1);
            aluno.Endereco = new Endereco() { Rua = "Rua 1", Numero = 1, Bairro = "Vila São Paulo", Cidade = "São Paulo", UF = "SP" };

            IList<Curso> cursos = new List<Curso>();

            cursos.Add(new Curso() { Id = 1, Nome = "Dev C#", CargaHoraria = 32 });
            cursos.Add(new Curso() { Id = 2, Nome = "Dev JS", CargaHoraria = 32 });

            aluno.Cursos = cursos;

            alunos.Add(aluno);



            aluno = new Aluno();
            aluno.Id = 2;
            aluno.Nome = "Anotnio Xavier";
            aluno.CPF = "12345678901";
            aluno.DataNascimento = new DateTime(1990, 1, 1);
            aluno.Endereco = new Endereco() { Rua = "Rua 1", Numero = 1, Bairro = "Vila São Paulo", Cidade = "São Paulo", UF = "SP" };

            cursos = new List<Curso>();

            cursos.Add(new Curso() { Id = 1, Nome = "Dev C#", CargaHoraria = 32 });
            cursos.Add(new Curso() { Id = 2, Nome = "Dev JS", CargaHoraria = 32 });

            aluno.Cursos = cursos;

            alunos.Add(aluno);

            return alunos;
        }
    }
}
