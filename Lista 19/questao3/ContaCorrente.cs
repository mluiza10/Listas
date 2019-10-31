using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao3
{
    class ContaCorrente
    {
        private string titular;
        private string NumeroConta;
        protected double saldo;

        public ContaCorrente(string titular, string NumeroConta)
        {
            this.titular = titular;
            this.NumeroConta = NumeroConta;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0) throw new ArgumentOutOfRangeException("O valor é inválido");
            else
                saldo = saldo + valor;
        }

        public virtual bool Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException("O valor é inválido");
            }

            if (saldo - valor < 0)
            {
                return false;
            }

            else
                saldo = saldo - valor; return true;
        }

        public double RetornarSaldo()
        {
            return saldo;
        }

        public override string ToString()
        {
            return $"{titular} - {NumeroConta} - {saldo}";
        }
    }
}
