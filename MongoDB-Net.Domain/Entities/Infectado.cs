using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Cpf = cpf;
            Nome = nome;
            Telefone = telefone;
            Estado = estado;
        }
    }
}
