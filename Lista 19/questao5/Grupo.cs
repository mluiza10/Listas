using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao5
{
    class Grupo
    {
        private string descricao;
        private Contato[] contatos = new Contato[10];
        private int contC;

        public Grupo(string d) { descricao = d; }

        public void Adicionar(Contato c)
        {
            if (contC < 10) contatos[contC++] = c;
        }

        public void Excluir(Contato c)
        {
            int p = Array.IndexOf(contatos, c);
            for (int i = p + 1; i < contC; i++)
            {
                contatos[i - 1] = contatos[i];
            }
            contC--;
        }

        public Contato[] ListarContatos()
        {
            Contato[] c = new Contato[contC];
            Array.Copy(contatos, c, contC);

            return c;
        }


        public override string ToString()
        {
            return $"{contC} - {descricao}";
        }
    }
}
