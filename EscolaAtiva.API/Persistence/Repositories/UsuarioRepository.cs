using EscolaAtiva.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace EscolaAtiva.API.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EscolaAtivaContext _context;

        public UsuarioRepository(EscolaAtivaContext context)
        {
            _context = context;
        }

        public void Add(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void AddAtividade(Atividade atividade)
        {
            _context.Atividades.Add(atividade);
            _context.SaveChanges();
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario GetById(int id)
        {
            return _context.Usuarios
                    .Include(x => x.Atividades)
                    .SingleOrDefault(x => x.IdUsuario == id);
        }

        public void Update(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void Delete(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }
    }
}