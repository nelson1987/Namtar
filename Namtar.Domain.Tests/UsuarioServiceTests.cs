using Moq;
using Namtar.Domain.Entities;
using Namtar.Domain.Interfaces;
using Namtar.Domain.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Namtar.Domain.Tests
{
    [TestFixture(Author = "Nelson Neto", TestName = "UsuarioServiceDomain", Description = "Usuario", TestOf = typeof(UsuarioService))]
    public class UsuarioServiceTests
    {
        private Mock<IUsuarioRepository> _mock { get; set; }

        [SetUp]
        public void Initialize()
        {
            _mock = new Mock<IUsuarioRepository>();
            _mock.Setup(foo => foo.BuscarTodos())
                .Returns(new List<Usuario> { new Usuario("Nelson Neto", "nelson.ash@outlook.com", "123456") });
        }

        [TestCase("nelson.ash@outlook.com",
            Author = "Nelson Neto", TestName = "Buscar usuário por e-mail", TestOf = typeof(UsuarioService))]
        public void BuscarUsuarioPorEmail(string email)
        {
            _mock.Setup(foo => foo.Buscar(It.IsAny<Func<Usuario, bool>>()))
                   .Returns(new Usuario("Nelson Neto", email, "123456"));
            IUsuarioService usuarioService = new UsuarioService(_mock.Object);
            var usuarioEncontrado = usuarioService.BuscarPorEmail(email);
            Assert.AreEqual(usuarioEncontrado.Email, email);
        }

        [TestCase("nelson.ash@outlook.com",
            Author = "Nelson Neto", TestName = "Buscar usuário por e-mail não cadastrado", TestOf = typeof(UsuarioService))]
        public void BuscarUsuarioPorEmailQueNaoEstaRegistrado(string email)
        {
            _mock.Setup(foo => foo.Buscar(It.IsAny<Func<Usuario, bool>>()));
            IUsuarioService usuarioService = new UsuarioService(_mock.Object);
            var usuarioEncontrado = usuarioService.BuscarPorEmail(email);
            Assert.IsNull(usuarioEncontrado);
        }

        //public Usuario Buscar(string email)
        //{
        //    return repository.Buscar(x => x.Email == email);
        //}

        //public List<Usuario> Consultar()
        //{
        //    return repository.BuscarTodos();
        //}

        //public void Inserir(Usuario entity)
        //{
        //    repository.Insert(entity);
        //}
    }
}
