using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    class retangulo
    {
        private double b, h;
        public retangulo(double b, double h)
        {
            if (b > 0) this.b = b;
            if (h > 0) this.h = h;
        }

        public double GetBase()
        {
            return b;
        }

        public double GetAltura()
        {
            return h;
        }

        public double CalcArea()
        {
            return h * b;
        }

        public double CalcDiagonal()
        {
            return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
        }

        public override string ToString()
        {
            return $"{CalcDiagonal()} -- {CalcArea()}";
        }
    }
}
