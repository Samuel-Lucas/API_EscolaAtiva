using System.Collections.Generic;
using EscolaAtiva.API.Enums;

namespace EscolaAtiva.API.Entities
{
    public class Usuario
    {
        public Usuario(string nome, EGenero genero, string perfil, string email, string senha)
        {
            Nome = nome;
            Genero = genero;
            Perfil = perfil;
            Email = email;
            Senha = senha;
            Atividades = new List<Atividade>();
        }

        public int IdUsuario { get; private set; }
        public string Nome { get; private set; }
        public EGenero Genero { get; private set; }
        public string Perfil { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public IList<Atividade> Atividades { get; set; }
    }
}