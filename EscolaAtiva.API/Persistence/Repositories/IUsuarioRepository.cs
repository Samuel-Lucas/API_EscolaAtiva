using EscolaAtiva.API.Entities;
using EscolaAtiva.API.Models;

namespace EscolaAtiva.API.Persistence.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        Usuario GetById(int id);
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(Usuario usuario);
        void AddAtividade(Atividade atividade);
    }
}