using Namtar.Application.Exceptions;
using Namtar.Application.Interfaces;
using Namtar.Domain.Entities;
using Namtar.Domain.Interfaces;
using System.Collections.Generic;

namespace Namtar.Application
{
    public class UsuarioApplicationService : IUsuarioApplicationService
    {
        public UsuarioApplicationService(IUsuarioService service)
        {
            this.service = service;
        }

        private IUsuarioService service { get; set; }

        public List<Usuario> ConsultarUsuario()
        {
            return service.Consultar();
        }

        public void IncluirUsuario(Usuario entity)
        {
            entity.IsValid();

            //Validar se há algum com o mesmo email
            //if (service.Buscar(entity.Email) != null)
            //    throw new ApplicationServiceException("Já existe usuário cadastrado com esse email");

            service.Inserir(entity);
            //Incluir
            //throw new NotImplementedException();
        }
    }
}
