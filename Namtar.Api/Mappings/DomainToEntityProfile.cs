﻿using AutoMapper;
using Namtar.Api.Contracts;

namespace Namtar.Api.Mappings
{
    public class DomainToEntityProfile : Profile
    {
        //construtor..
        public DomainToEntityProfile()
        {
            #region Entity to ViewModel
            CreateMap<Usuario, CriacaoUsuario>();
            //.ForMember(dest => dest.Total,
            //src => src.MapFrom(p => p.Preco * p.Quantidade));
        }
    }
}