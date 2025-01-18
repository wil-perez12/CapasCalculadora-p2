using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAceso
{
    interface IDatosCalculados
    {
        void AgrgarHistorial(string operation, int result);
        List<string> ObtenerHistorial();

    }
}
