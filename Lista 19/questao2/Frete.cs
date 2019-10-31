using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao2
{
    class Frete
    {
        private double distancia, peso;

        public Frete(double dis, double p)
        {
            if (dis > 0)
            {
                distancia = dis;
            }

            if (p > 0)
            {
                peso = p;
            }
        }

        public double GetPeso()
        {
            return peso;
        }

        public double GetDistancia()
        {
            return distancia;
        }

        public virtual decimal CalcFrete()
        {
            return Convert.ToDecimal(distancia * peso) * Convert.ToDecimal(0.01);

        }

        public override string ToString()
        {
            return $"{distancia} --- {peso} --- {CalcFrete()}";
        }
    }
}
