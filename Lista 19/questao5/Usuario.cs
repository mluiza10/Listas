using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao5
{
    class Usuario : Contato
    {
        private Contato[] contatos = new Contato[10];
        private Grupo[] grupos = new Grupo[10];
        private int contC, contG;

        public Usuario(string n, string f) : base(n, f) { }

        public void InserirContato(Contato c)
        {
            if (contC < 10) contatos[contC++] = c;
        }

        public void InserirGrupo(Grupo g)
        {
            if (contG < 10) grupos[contG++] = g;
        }

        public Contato[] ListarContatos()
        {
            Contato[] c = new Contato[contC];
            Array.Copy(contatos, c, contC);

            return c;
        }

        public Grupo[] ListarGrupos()
        {
            Grupo[] g = new Grupo[contG];
            Array.Copy(grupos, g, contG);

            return g;
        }

        public override string ToString()
        {
            return $"{base.GetNome()} - {base.GetFone()}";
        }

    }
