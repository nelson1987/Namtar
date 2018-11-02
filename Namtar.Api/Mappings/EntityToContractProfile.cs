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

            CreateMap<ConsultaUsuario, Usuario>()
            .ForMember(dest => dest.Senha, src => src.Ignore());
            //src => src.MapFrom(p => p.Preco * p.Quantidade));

            #endregion
        }
    }
}
