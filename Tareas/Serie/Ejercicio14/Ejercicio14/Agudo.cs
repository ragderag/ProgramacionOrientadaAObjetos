using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    class Agudo : IAngulo
    {
        double angulo;

        public double Angulo { get; set; }
        public string Caracteristicas()
        {
            return string.Format("Mido más de 0 grados y menos de 90");
        }
        public bool Calcular()
        {
            if (Angulo > 0 && Angulo < 90)
            {
                return true;
            }
            return false;
        }
    }
}
