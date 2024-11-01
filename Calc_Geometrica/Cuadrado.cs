using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Geometrica
{
    public class Cuadrado:FigurasGeometricas
    {
        double b {  get; set; }
        double h { get; set; }

        public Cuadrado(double b, double h) { 
        
            this.b = b; 
            this.h = h;
        
        }


        public override double CalcularArea()
        {
            return b* h;
        }

    }
}
