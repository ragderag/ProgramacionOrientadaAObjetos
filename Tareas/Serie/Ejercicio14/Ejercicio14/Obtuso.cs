using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    class Obtuso: IAngulo
    {
        double angulo;

        public double Angulo { get; set; }
        public string Caracteristicas()
        {
            return string.Format("Mido más de 90 grados pero menos que 180");
        }

        public bool Calcular()
        {
            if (Angulo > 90 && Angulo < 180)
            {
                return true;
            }
            return false;
        }
    }
}
