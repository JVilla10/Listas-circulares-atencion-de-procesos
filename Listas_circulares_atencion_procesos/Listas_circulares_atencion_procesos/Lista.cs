using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_circulares_atencion_procesos
{
    class Lista
    {
        static Random probabilidad = new Random();
        private Proceso primero;
        private Proceso ultimo;
        private Proceso tmp;
        public string mostrar = "";

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public int probabilidadAgregar()
        {
            int agregar = probabilidad.Next(1, 5);

            if(agregar == 1)
            {
                return 1;
            }
            else
            {
                return -777;
            }
        }

        public void push(Proceso nuevoProceso)
        {
            if(primero == null)
            {
                primero = nuevoProceso;
                ultimo = primero;
                primero.siguiente = primero;
            }
            else
            {
                ultimo.siguiente = nuevoProceso;
                nuevoProceso.siguiente = primero;
                ultimo = nuevoProceso;
            }
        }

        public void eliminar(Proceso procesillo)
        {
            Proceso tmp = primero;
            Proceso anterior = ultimo;

            primero = primero.siguiente;
            ultimo = primero;   
        }

        public Proceso peek()
        {
            return primero;
        }

        public Proceso restar()
        {
            tmp = tmp.siguiente;

            if(tmp.tamañoProceso != 0)
            {
                tmp.disminuir();
            }

            return tmp;
        }

        public override string ToString()
        {
            Proceso tmp = primero;

            if(tmp != null)
            {
                while(tmp.siguiente != primero)
                {
                    mostrar += tmp.ToString();
                    tmp = tmp.siguiente;
                }
                mostrar += tmp.ToString();
            }

            return mostrar;
        }
    }
}
