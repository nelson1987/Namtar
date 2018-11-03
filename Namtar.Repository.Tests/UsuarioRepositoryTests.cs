using Moq;
using Namtar.Domain.Entities;
using Namtar.Domain.Interfaces;
using Namtar.Repository.Exceptions;
using NUnit.Framework;

namespace Namtar.Repository.Tests
{
    [TestFixture(Author = "Nelson Neto", TestName = "UsuarioRepository", Description = "Repositorio de Usuario", 
        TestOf = typeof(UsuarioRepository))]
    public class UsuarioRepositoryTests
    {
        private Mock<IUsuarioRepository> _mock { get; set; }

        [TestCase("Nelson Neto", "nelson.ash@outlook.com", "123456",
            Author = "Nelson Neto", TestName = "Tentar inserir usuário completo", TestOf = typeof(UsuarioRepository))]
        public void InserirUsuarioSemNome(string nome, string email, string senha)
        {
            _mock = new Mock<IUsuarioRepository>();
            _mock.Setup(foo => foo.Insert(new Usuario("", "nelson.ash@outlook.com", "123456")))
                .Throws(new RepositoryException("Nome deve estar preenchido"));
        }
    }
}
