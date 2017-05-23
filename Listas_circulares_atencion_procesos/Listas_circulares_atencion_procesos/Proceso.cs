using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_circulares_atencion_procesos
{
    class Proceso
    {
        Random random = new Random();
        public Proceso siguiente;
        public Proceso tmp;
        private int _tamañoProceso;

        public Proceso()
        {
            _tamañoProceso = random.Next(4, 15);
        }

        public int tamañoProceso
        {
            get { return _tamañoProceso; }
        }

        public int disminuir()
        {
            int disminuir = _tamañoProceso--;
            return disminuir;
        }

        public override string ToString()
        {
            return "Proceso: " + _tamañoProceso + "\r\n";
        }
    }
}
