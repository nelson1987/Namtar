using Namtar.Domain.Entities;
using Namtar.Domain.Exceptions;
using NUnit.Framework;

namespace Namtar.Domain.Tests
{
    [TestFixture(Author = "Nelson Neto", TestName = "UsuarioDomain", Description = "Usuario", TestOf = typeof(Usuario))]
    public class UsuarioTests
    {
        [TestCase("Nelson Neto", "nelson.ash@outlook.com", "123456",
            Author = "Nelson Neto", TestName = "Tentar criar usuário completo", TestOf = typeof(Usuario))]
        public void CriarUsuarioCompleto(string nome, string email, string senha)
        {
            var usuario = new Usuario(nome, email, senha);
            Assert.AreEqual(true, usuario.IsValid());
        }

        [TestCase("", "nelson.ash@outlook.com", "123456",
            Author = "Nelson Neto", TestName = "Tentar criar usuário sem nome", TestOf = typeof(Usuario))]
        public void CriarUsuarioSemNome(string nome, string email, string senha)
        {
            var usuario = new Usuario(nome, email, senha);
            Assert.Throws<DomainValidarionException>(() => usuario.IsValid(), "Nome deve estar preenchido");
        }

        [TestCase("Nelson Neto", "", "123456",
            Author = "Nelson Neto", TestName = "Tentar criar usuário sem email", TestOf = typeof(Usuario))]
        public void CriarUsuarioSemEmail(string nome, string email, string senha)
        {
            var usuario = new Usuario(nome, email, senha);
            Assert.Throws<DomainValidarionException>(() => usuario.IsValid(), "Email deve estar preenchido");
        }

        [TestCase("Nelson Neto", "nelson.ash@outlook.com", "",
            Author = "Nelson Neto", TestName = "Tentar criar usuário sem senha", TestOf = typeof(Usuario))]
        public void CriarUsuarioSemSenha(string nome, string email, string senha)
        {
            var usuario = new Usuario(nome, email, senha);
            Assert.Throws<DomainValidarionException>(() => usuario.IsValid(), "Senha deve estar preenchida");
        }
    }
}

