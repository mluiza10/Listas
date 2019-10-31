using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao4
{
    class Construtora
    {
        private List<Funcionario> funcs = new List<Funcionario>();

        public void Inserir(Funcionario f)
        {
            funcs.Add(f);
        }

        public List<Funcionario> Funcionarios()
        {
            return funcs;
        }

        public List<Engenheiro> Engenheiros()
        {
            List<Engenheiro> engenheiros = new List<Engenheiro>();

            foreach (object i in funcs)
            {
                if ((i as Funcionario) is Engenheiro) engenheiros.Add(i as Engenheiro);
            }

            return engenheiros;
        }

        public List<Motorista> Motoristas()
        {
            List<Motorista> motoristas = new List<Motorista>();

            foreach (object i in funcs)
            {
                if ((i as Funcionario) is Motorista) motoristas.Add(i as Motorista);
            }

            return motoristas;
        }

    }
}
