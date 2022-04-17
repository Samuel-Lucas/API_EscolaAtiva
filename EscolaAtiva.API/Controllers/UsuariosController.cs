using EscolaAtiva.API.Entities;
using EscolaAtiva.API.Models;
using EscolaAtiva.API.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EscolaAtiva.API.Controllers
{
    [ApiController]
    [Route("api/escola-ativa/usuarios")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet("todos-os-usuarios")]
        public IActionResult GetAllUsers()
        {
            var usuarios = _usuarioRepository.GetAll();
            return Ok(usuarios);
        }

        [HttpGet("usuario/{id}")]
        public IActionResult GetUser(int id)
        {
            var usuario = _usuarioRepository.GetById(id);

            if(usuario == null)
                return NotFound();

            return Ok(usuario);
        }

        [HttpPost("adicionar-usuario")]
        public IActionResult AddUser(AddUsuarioInputModel novoUsuario)
        {
            var usuario = new Usuario(
                novoUsuario.Nome,
                novoUsuario.Genero,
                novoUsuario.Perfil,
                novoUsuario.Email,
                novoUsuario.Senha
            );

            _usuarioRepository.Add(usuario);

            return CreatedAtAction(
                "GetUser",
                new { id = usuario.IdUsuario },
                usuario);
        }

        [HttpPut("atualizar-usuario/{id}")]
        public IActionResult UpdateUser(int id, UpdateUsuarioInputModel updateUsuario)
        {
            var usuario = _usuarioRepository.GetById(id);

            if(usuario == null)
                return NotFound();

            usuario.UpdateEntityUser(
                updateUsuario.Nome,
                updateUsuario.Genero,
                updateUsuario.Perfil,
                updateUsuario.Email
            );

            _usuarioRepository.Update(usuario);

            return NoContent();
        }

        [HttpDelete("remover-usuario/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var usuario = _usuarioRepository.GetById(id);

            if(usuario == null)
                return NotFound();

            _usuarioRepository.Delete(usuario);

            return Ok();
        }
    }
}