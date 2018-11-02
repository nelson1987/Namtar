using Namtar.Domain.Entities;
using Namtar.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace Namtar.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public Usuario Buscar(Func<Usuario, bool> predicate)
        {
            throw new NotFiniteNumberException();
        }

        public List<Usuario> BuscarTodos()
        {
            throw new NotFiniteNumberException();
        }

        public void Insert(Usuario entity)
        {
            throw new NotFiniteNumberException();
        }
    }
}
