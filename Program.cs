using AdapterPattern.Adapter;
using AdapterPattern.Target;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] alunos = new string[5, 4]
            {
                {"101","Maria","Artes","1000"},
                {"102","Pedro","Engenharia","2000"},
                {"103","Bianca","Veterinária","3000"},
                {"104","Pamela","Moda","900"},
                {"105","Sergio","Desenho","850"},
            };

            ITarget target = new AlunoAdapter();
            target.ProcessarCalculoMensalidade(alunos);
        }
    }
}
