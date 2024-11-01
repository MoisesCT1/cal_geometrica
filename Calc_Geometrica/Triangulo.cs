using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Geometrica
{
    public class Triangulo : FigurasGeometricas
    {
        // Propiedades para los lados del triángulo
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        // Constructor que inicializa los lados
        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
            this.LadoC = ladoC;
        }

        // Método para calcular el perímetro del triángulo
        public double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        // Método para calcular el área usando la fórmula de Herón
        public override double CalcularArea()
        {
            double semiPerimetro = CalcularPerimetro() / 2;
            return Math.Sqrt(semiPerimetro * (semiPerimetro - LadoA) * (semiPerimetro - LadoB) * (semiPerimetro - LadoC));
        }
    }
}

