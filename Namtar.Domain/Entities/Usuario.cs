using Namtar.Domain.Exceptions;

namespace Namtar.Domain.Entities
{
    public class Usuario
    {
        protected Usuario()
        {

        }

        public Usuario(string nome, string email, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new DomainValidarionException("Nome deve estar preenchido");

            if (string.IsNullOrEmpty(Email))
                throw new DomainValidarionException("Email deve estar preenchido");

            if (string.IsNullOrEmpty(Senha))
                throw new DomainValidarionException("Senha deve estar preenchida");

            return true;
        }
    }
}
