using EscolaAtiva.API.Enums;

namespace EscolaAtiva.API.Models
{
    public record AddUsuarioInputModel(
        string Nome,
        EGenero Genero,
        string Perfil,
        string Email,
        string Senha)
    {
        
    }
}