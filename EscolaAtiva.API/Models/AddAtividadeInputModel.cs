using EscolaAtiva.API.Enums;

namespace EscolaAtiva.API.Models
{
    public record AddAtividadeInputModel(
        EDisciplina disciplina,
        string metodologia,
        string titulo,
        string descricao,
        int idAutor
    )
    {
        
    }
}