using EscolaAtiva.API.Enums;

namespace EscolaAtiva.API.Entities
{
    public class Atividade
    {
        public Atividade(EDisciplina disciplina, string metodologia, string titulo, string descricao, int idAutor)
        {
            Disciplina = disciplina;
            Metodologia = metodologia;
            Titulo = titulo;
            Descricao = descricao;
            IdAutor = idAutor;
        }

        public int IdAtividade { get; private set; }
        public EDisciplina Disciplina { get; private set; }
        public string Metodologia { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int IdAutor { get; private set; }  // FK Referencia IdUsuario
    }
}