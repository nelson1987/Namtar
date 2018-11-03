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

            CreateMap<CriacaoUsuario, Usuario>();

            #endregion
        }
    }
}
