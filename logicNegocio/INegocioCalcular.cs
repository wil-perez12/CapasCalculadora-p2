using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicNegocio
{
    interface INegocioCalcular
    {
        void sumar(int a, int b);
        void restar(int a, int b);
        void multiplicar(int a, int b);
        void dividir (int a, int b);
    }
}
