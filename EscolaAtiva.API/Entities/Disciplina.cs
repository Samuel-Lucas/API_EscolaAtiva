using EscolaAtiva.API.Enums;

namespace EscolaAtiva.API.Entities
{
    public class Disciplina
    {
        public Disciplina(string nomeDisciplina, EDisciplina codigoDisciplina)
        {
            NomeDisciplina = nomeDisciplina;
            CodigoDisciplina = codigoDisciplina;
        }

        public int IdDisciplina { get; private set; }
        public string NomeDisciplina { get; private set; }
        public EDisciplina CodigoDisciplina { get; set; }
    }
}