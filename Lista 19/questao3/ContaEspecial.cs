using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao3
{
    class ContaEspecial : ContaCorrente
    {
        private double limite;

        public ContaEspecial(string titular, string NumeroConta, double limite) : base(titular, NumeroConta)
        {

            this.limite = limite;
        }

        public override bool Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException("Valor inválido");
            }

            if (saldo - valor < 0)
            {
                if (Math.Abs(saldo - valor) <= limite)
                {
                    return true;
                }

                else
                    return false;
            }

            else
            {
                saldo = saldo - valor;
                return true;
            }
        }
    }
}
