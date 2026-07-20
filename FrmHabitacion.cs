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
    public partial class FrmHabitacion : Form
    {
        public FrmHabitacion()
        {
            InitializeComponent();
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            string Estado = lblEstadoHab.Text;
            CambiarColor(Estado);
        }

        private void CambiarColor(string Estado)
        {
            switch (Estado)
            {
                case "Disponible":
                    lblEstadoHab.Text = "Disponible";
                    lblEstadoHab.ForeColor = Color.Green;
                break;

                case "Mantenimiento":
                    lblEstadoHab.Text = "Mantenimiento";
                    lblEstadoHab.ForeColor = Color.Orange;
                break;
            }
        }
    }
}
