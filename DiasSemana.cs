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
    public partial class DiasSemana : Form
    {
        public DiasSemana()
        {
            InitializeComponent();
        }

        private void DiasSemana_Load(object sender, EventArgs e)
        {
            string[] diasSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            cboDias.Items.Clear(); //Clear es para que aparezca limpio por defecto

            foreach (string dias in diasSemana)
            {
                cboDias.Items.Add(dias);
            }
        }
    }
}
