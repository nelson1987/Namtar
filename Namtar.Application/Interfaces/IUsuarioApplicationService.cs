﻿using Namtar.Domain;
using System.Collections.Generic;

namespace Namtar.Application.Interfaces
{
    public interface IUsuarioApplicationService
    {
        void IncluirUsuario();//Usuario entity);
        List<Usuario> ConsultarUsuario();
    }
}
