using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao3
{
    class Poupança : ContaCorrente
    {
        public Poupança(string titular, string NumeroConta) : base(titular, NumeroConta)
        {

        }

        public void Render(double juros)
        {
            saldo = saldo + saldo * juros;
        }
    }
}
