using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Geometrica
{
    public class Elipse : FigurasGeometricas
    {
        // Propiedades para los semiejes de la elipse
        public double SemiEjeMayor { get; set; }
        public double SemiEjeMenor { get; set; }

        // Constructor que inicializa los semiejes
        public Elipse(double semiEjeMayor, double semiEjeMenor)
        {
            this.SemiEjeMayor = semiEjeMayor;
            this.SemiEjeMenor = semiEjeMenor;
        }

        // Método para calcular el área de la elipse
        public override double CalcularArea()
        {
            return Math.PI * SemiEjeMayor * SemiEjeMenor;
        }

        // Método para calcular el perímetro aproximado de la elipse
        public double CalcularPerimetro()
        {
            // Usamos la aproximación de Ramanujan para el perímetro
            double h = Math.Pow((SemiEjeMayor - SemiEjeMenor), 2) / Math.Pow((SemiEjeMayor + SemiEjeMenor), 2);
            return Math.PI * (SemiEjeMayor + SemiEjeMenor) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
        }
    }
}

