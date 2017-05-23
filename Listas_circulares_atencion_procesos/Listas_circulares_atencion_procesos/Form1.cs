using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_circulares_atencion_procesos
{
    public partial class Form1 : Form
    {
        Lista miLista = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Proceso miProceso = new Proceso();
            int agregados = 0;
            int eliminados = 0;
            int pendientes = 0;
            int cicloVacio = 0;

            for (int i = 1; i <= 200; i++)
            {
                if (miLista.probabilidadAgregar() == 1)
                {
                    miLista.push(miProceso);
                    agregados++;
                    pendientes++;
                }

                if(miLista.peek() != null)
                {
                    miLista.peek().disminuir();

                    if(miLista.peek().tamañoProceso == 0)
                    {
                        miLista.eliminar(miLista.peek());
                        pendientes--;
                        eliminados++;
                    }
                }
                else
                {
                    cicloVacio++;
                }
            }
            txtResultado.Text = "Total de procesos agregados: " + agregados + "\r\n" + 
                "Eliminados: " + eliminados + "\r\n" + "Procesos pendientes: " + pendientes + "\r\n" +
                "Total de veces, donde el ciclo estaba vacio: " + cicloVacio;
        } 
    }
}
