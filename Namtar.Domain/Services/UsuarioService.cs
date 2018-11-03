using System.Collections.Generic;
using Namtar.Domain.Entities;
using Namtar.Domain.Interfaces;

namespace Namtar.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository repository { get; set; }

        public UsuarioService(IUsuarioRepository repository)
        {
            this.repository = repository;
        }

        public Usuario Buscar(string email)
        {
            return repository.Buscar(x => x.Email == email);
        }

        public List<Usuario> Consultar()
        {
            return repository.BuscarTodos();
        }

        public void Inserir(Usuario entity)
        {
            repository.Insert(entity);
        }
    }
}
