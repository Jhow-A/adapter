using AdapterPattern.Domain;
using System;
using System.Collections.Generic;

namespace AdapterPattern.Adaptee
{
    class SistemaMensalidade
    {
        public void CalcularMensalidade(List<Aluno> alunos)
        {
            alunos.ForEach(delegate (Aluno aluno)
            {
                Console.WriteLine($"Aluno: {aluno.Nome} - Mensalidade: {aluno.Mensalidade}");
            });
        }
    }
}
