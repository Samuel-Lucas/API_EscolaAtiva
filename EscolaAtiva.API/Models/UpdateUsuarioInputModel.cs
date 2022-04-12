using EscolaAtiva.API.Enums;

namespace EscolaAtiva.API.Models
{
    public record UpdateUsuarioInputModel(
        string Nome,
        EGenero Genero,
        string Perfil,
        string Email
    )
    {
        
    }
}