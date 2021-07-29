using AdapterPattern.Adaptee;
using AdapterPattern.Domain;
using AdapterPattern.Target;
using System;
using System.Collections.Generic;

namespace AdapterPattern.Adapter
{
    class AlunoAdapter : ITarget
    {
        private SistemaMensalidade sistema = new SistemaMensalidade();
        public void ProcessarCalculoMensalidade(string[,] alunos)
        {
            string id = null;
            string nome = null;
            string curso = null;
            string mensalidade = null;

            var listaAlunos = new List<Aluno>();

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                for (int j = 0; j < alunos.GetLength(1); j++)
                {
                    if (j == 0)
                        id = alunos[i, j];
                    else if (j == 1)
                        nome = alunos[i, j];
                    else if (j == 2)
                        curso = alunos[i, j];
                    else if (j == 3)
                        mensalidade = alunos[i, j];

                    // SWITCH
                }

                listaAlunos.Add(new Aluno()
                {
                    Id = int.Parse(id),
                    Nome = nome,
                    Curso = curso,
                    Mensalidade = decimal.Parse(mensalidade)
                });
            }

            Console.WriteLine("Conversão concluída com sucesso \n");

            sistema.CalcularMensalidade(listaAlunos);
        }
    }
}
