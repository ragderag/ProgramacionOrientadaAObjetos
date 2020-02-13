using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    class Llano
    {
        double angulo;

        public double Angulo { get; set; }
        public string Caracteristicas()
        {
            return string.Format("Mido exactamente 180 grados");
        }

        public bool Calcular()
        {
            if (Angulo == 180)
            {
                return true;
            }
            return false;
        }
    }
}
