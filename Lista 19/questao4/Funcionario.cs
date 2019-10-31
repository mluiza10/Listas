using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao4
{
    class Funcionario
    {
        private string nome, email, fone;

        public string Nome { set { nome = value; } get => nome; }
        public string Email { set { email = value; } get => email; }
        public string Fone { set { fone = value; } get => fone; }

        public override string ToString()
        {
            return $"{nome} {email} {fone}";
        }
    }
}
