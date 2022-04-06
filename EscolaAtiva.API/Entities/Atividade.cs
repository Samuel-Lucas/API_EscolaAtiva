namespace EscolaAtiva.API.Entities
{
    public class Atividade
    {
        public Atividade(string disciplina, string metodologia, string titulo, string descricao, string idAutor)
        {
            Disciplina = disciplina;
            Metodologia = metodologia;
            Titulo = titulo;
            Descricao = descricao;
            IdAutor = idAutor;
        }

        public int IdAtividade { get; private set; }
        public string Disciplina { get; private set; }
        public string Metodologia { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public string IdAutor { get; private set; }  // FK Referencia IdUsuario
    }
}