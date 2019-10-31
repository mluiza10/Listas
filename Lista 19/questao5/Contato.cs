using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao5
{
    class Contato
    {

        private string nome, fone;

        public Contato(string n, string f)
        {
            nome = n;
            fone = f;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetFone()
        {
            return fone;
        }

        public override string ToString()
        {
            return $"{nome} - {fone}";
        }
    }
}
