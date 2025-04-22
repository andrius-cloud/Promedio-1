using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Promedio_1.Calculadora
{
    internal class Division
    {
        private float a;
        private float b;

        public Division(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public float Calculo()
        {
            return a / b;
        }
    }
}
