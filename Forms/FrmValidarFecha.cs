using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSoftwareDeveloper.Forms
{
    public partial class FrmValidarFecha : Form
    {
        public FrmValidarFecha()
        {
            InitializeComponent();
        }

        private bool ValidarFecha(string fecha)
        {
            DateTime resultado;
            bool Valida = DateTime.TryParseExact(fecha, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out resultado);
            return Valida;
        }

        private void btnValidarFecha_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;

            if (ValidarFecha(fecha))
            {
                MessageBox.Show("Formato de fecha válido.");
            }
            else
            {
                MessageBox.Show("Formato de fecha no válido.");
            }
        }
    }
}


