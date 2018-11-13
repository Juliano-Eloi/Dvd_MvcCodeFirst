using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace Dvd_MvcCodeFirst.Models
{
    public class InicializarBanco : DropCreateDatabaseAlways<BancoContexto>
    {
        protected override void Seed(BancoContexto context)
        {
            //criar alguns dados no banco
            new List<Professor>
            {
                new Professor
                {
                    Nome = "Primeiro Prof",
                    Materia = "ASP.NET MVC",
                    Salario = 4000,
                    Telefone = "11111111",
                    TwitterBlog = "https://www.google.com",
                    Disponivel = true,
                    Admissao = new DateTime(2012, 05,01),
                    Alunos = new List<Aluno>
                    {
                        new Aluno
                        {
                            NomeAluno = "Bruno1",
                            Email = "bruno1@abc.com",
                            Aprovado = true,
                            Ano = 2011,
                            Inscricao = new DateTime(2011, 8, 12)
                        },
                        new Aluno
                        {
                            NomeAluno = "Bruno2",
                            Email = "bruno2@abc.com",
                            Aprovado = false,
                            Ano = 2011,
                            Inscricao = new DateTime(2011, 7, 13)
                        }
                    },
                    Topicos = new List<Topico>
                    {
                        new Topico { Descricao = "topico 1" },
                        new Topico { Descricao = "topico 2" }
                    }
                },
                new Professor
                {
                    Nome = "Segundo Prof",
                    Materia = "ASP.NET MVC Intermediário",
                    Salario = 6000,
                    Telefone = "22222222",
                    TwitterBlog = "https://www.google.com",
                    Disponivel = true,
                    Admissao = new DateTime(2010, 06, 02),
                    Alunos = new List<Aluno>
                    {
                        new Aluno
                        {
                            NomeAluno = "Bruno3",
                            Email = "bruno3@abc.com",
                            Aprovado = true,
                            Ano = 2010,
                            Inscricao = new DateTime(2010, 3, 10)
                        },
                        new Aluno
                        {
                            NomeAluno = "Bruno4",
                            Email = "bruno4@abc.com",
                            Aprovado = false,
                            Ano = 2010,
                            Inscricao = new DateTime(2010, 7, 13)
                        }
                    },
                    Topicos = new List<Topico>
                    {
                        new Topico { Descricao = "topico 3" },
                        new Topico { Descricao = "topico 4" },
                        new Topico { Descricao = "topico 5" }
                    }
                }
            }.ForEach(p => context.Professores.Add(p));
            base.Seed(context);
        }
    }
}
