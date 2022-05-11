
using MongoDB_Net.Domain.Validation;

namespace MongoDB_Net.Domain.Entities
{
    public class Infectado : Entity
    {
        public string Cpf { get; private set; }

        public string Nome { get; private set; }

        public string Telefone { get; private set; }

        public string Estado { get; private set; }

        
        public Infectado(string cpf, string nome, string telefone, string estado)
        {
            ValidateInfectado(cpf, nome, telefone, estado);
        }

        private void ValidateInfectado(string cpf, string nome, string telefone, string estado)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(cpf),
                "Invalid cpf. cpf is required");

            DomainExceptionValidation.When(nome.Length < 3,
                "Invalid nome, too short, minimum 3 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(telefone),
                "Invalid telefone. telefone is required");

            DomainExceptionValidation.When(estado.Length <= 1,
                "Invalid estado, too short, minimum 2 characters");

            Cpf = cpf;
            Nome = nome;
            Telefone = telefone;
            Estado = estado;
        }
    }
}
