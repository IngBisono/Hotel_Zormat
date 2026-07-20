using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Zormat
{
    public partial class FrmNuevaReserva : Form
    {
        public FrmNuevaReserva()
        {
            InitializeComponent();
        }

        private void FrmNuevaReserva_Load(object sender, EventArgs e)
        {
            //Array unidimensional
            string[] tipoHabitacion = {"Sencilla", "Doble", "Suite", "Presidencial"};
            cboTipoHabitacion.Items.Clear(); //Clear es para que aparezca limpio por defecto

            foreach (string tipo in tipoHabitacion)
            {
                cboTipoHabitacion.Items.Add(tipo);
            }
        }
    }
}
