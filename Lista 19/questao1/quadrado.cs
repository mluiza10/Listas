using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    class quadrado : retangulo
    {
        
            private double l;
            public quadrado(double l) : base(l, l) { }


            public override string ToString()
            {
                return $"{CalcDiagonal()} -- {CalcArea()}";
            }
        
    }
}
