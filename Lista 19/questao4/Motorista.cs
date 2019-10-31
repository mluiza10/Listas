using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao4
{
    class Motorista : Funcionario
    {
        private string cnh;

        public string Cnh { set => cnh = value; get => cnh; }

        public override string ToString()
        {
            return $"{Nome} {Email} {Fone} - {cnh}";
        }
    }
}
