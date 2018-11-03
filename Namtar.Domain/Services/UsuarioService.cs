using System.Collections.Generic;
using Namtar.Domain.Entities;
using Namtar.Domain.Interfaces;

namespace Namtar.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository Repository { get; }

        public UsuarioService(IUsuarioRepository repository)
        {
            this.Repository = repository;
        }

        public Usuario BuscarPorEmail(string email)
        {
            return Repository.Buscar(x => x.Email == email);
        }

        public List<Usuario> Consultar()
        {
            return Repository.BuscarTodos();
        }

        public void Inserir(Usuario entity)
        {
            Repository.Insert(entity);
        }
    }
}
