using Namtar.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Namtar.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario Buscar(Func<Usuario,bool> predicate);
        List<Usuario> BuscarTodos();
        void Insert(Usuario entity);
    }
}
