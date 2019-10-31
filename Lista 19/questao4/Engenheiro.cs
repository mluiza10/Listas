using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao4
{
    class Engenheiro : Funcionario
    {
        private string crea;

        public string Crea { set => crea = value; get => crea; }

        public override string ToString()
        {
            return $"{Nome} {Email} {Fone} - {crea}";
        }
    }
}
