using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Geometrica
{
    public class Circulos:FigurasGeometricas
    {
        double radio {  get; set; }

        public Circulos(double radio) { 
            this.radio = radio;
        }

        public double CalcularDiametro()
        {

                return radio*2;

        }

        public double CalcularPerimetro() {

            return 2 * 3.141592 * radio * radio;
        }

        public override double CalcularArea()
        {
            return 3.141592 * radio * radio; 
        }

    }
}
