using AutoMapper;
using Namtar.Api.Contracts;
using Namtar.Domain.Entities;

namespace Namtar.Api.Mappings
{
    public class ContractToEntityProfile : Profile
    {
        public ContractToEntityProfile()
        {
            #region Entity to Contract

            CreateMap<Usuario, CriacaoUsuario>()
            .ForMember(dest => dest.ConfirmacaoSenha, src => src.Ignore());

            #endregion
        }
    }
}
