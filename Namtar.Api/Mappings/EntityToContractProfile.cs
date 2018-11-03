using AutoMapper;
using Namtar.Api.Contracts;
using Namtar.Domain.Entities;

namespace Namtar.Api.Mappings
{
    public class EntityToContractProfile : Profile
    {
        public EntityToContractProfile()
        {
            #region Entity to Contract

            CreateMap<Usuario, ConsultaUsuario>();

            #endregion
        }
    }
}
