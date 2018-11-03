using Namtar.Domain.Entities;
using System.Collections.Generic;

namespace Namtar.Domain.Interfaces
{
    public interface IUsuarioService
    {
        Usuario BuscarPorEmail(string email);
        void Inserir(Usuario entity);
        List<Usuario> Consultar();
    }
}
