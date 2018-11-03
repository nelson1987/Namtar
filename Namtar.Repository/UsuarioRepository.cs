using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Namtar.Domain.Entities;
using Namtar.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Z.Dapper.Plus;

namespace Namtar.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public IConfiguration _config { get; }

        public UsuarioRepository(IConfiguration configuration)
        {
            _config = configuration;
        }


        public Usuario Buscar(Func<Usuario, bool> predicate)
        {
            DapperPlusManager.Entity<Usuario>().Table("TB_USUARIO")
                .Map(x=>x.Id, "IDT_USUARIO")
                .Map(x=>x.Nome, "NOM_USUARIO")
                .Map(x => x.Email, "EMAIL_USUARIO")
                .Map(x => x.Senha, "SENHA_USUARIO");

            using (SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("BloggingDatabase")))
            {
                //conexao.GetHashCode<(new List<Usuario>() { entity });
                var invoice = conexao.Get<Usuario>(predicate);
            }
            throw new NotImplementedException();
        }

        public List<Usuario> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Insert(Usuario entity)
        {
            DapperPlusManager.Entity<Usuario>().Table("TB_USUARIO")
                .Map(x => x.Id, "IDT_USUARIO")
                .Map(x => x.Nome, "NOM_USUARIO")
                .Map(x => x.Email, "EMAIL_USUARIO")
                .Map(x => x.Senha, "SENHA_USUARIO");

            using (SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("BloggingDatabase")))
            {
                conexao.BulkInsert(new List<Usuario>() { entity });
            }
            //throw new NotFiniteNumberException();
        }
    }
}
