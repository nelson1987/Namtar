using System.Collections.Generic;
using Namtar.Domain.Entities;
using Namtar.Domain.Interfaces;
using Namtar.Domain.Interfaces.Repository;

namespace Namtar.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        public UsuarioService(IUsuarioRepository repository)
        {
            this.repository = repository;
        }

        private IUsuarioRepository repository { get; set; }

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
