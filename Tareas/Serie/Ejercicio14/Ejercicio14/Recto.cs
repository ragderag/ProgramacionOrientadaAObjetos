using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    class Recto: IAngulo
    {
        double angulo;

        public double Angulo { get; set; }
        public string Caracteristicas()
        {
            return string.Format("Mido 90 grados exactamente");
        }

        public bool Calcular()
        {
            if (Angulo == 90)
            {
                return true;
            }
            return false;
        }
    }
}
