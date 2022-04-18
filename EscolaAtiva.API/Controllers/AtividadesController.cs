using EscolaAtiva.API.Entities;
using EscolaAtiva.API.Models;
using EscolaAtiva.API.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EscolaAtiva.API.Controllers
{
    [ApiController]
    [Route("api/escola-ativa/atividades")]
    public class AtividadesController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public AtividadesController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost("incluir-atividade")]
        public IActionResult PostAtividade(int id, AddAtividadeInputModel model)
        {
            var usuario = _usuarioRepository.GetById(id);

            if(usuario == null)
                return NotFound();

            var atividade= new Atividade(
                model.disciplina,
                model.metodologia,
                model.titulo,
                model.descricao,
                id
            );
            
            _usuarioRepository.AddAtividade(atividade);
            
            return NoContent();
        }
    }
}