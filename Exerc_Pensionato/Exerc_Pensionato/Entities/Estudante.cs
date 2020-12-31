using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_Pensionato.Entities
{
    class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante()
        {
        }

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + ", E-mail: " + Email;
        }

    }
}
