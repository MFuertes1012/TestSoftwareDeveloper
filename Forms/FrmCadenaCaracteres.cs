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
    public partial class FrmCadenaCaracteres : Form
    {
        public FrmCadenaCaracteres()
        {
            InitializeComponent();
        }

        private int ContarCaracteres(string cadena)
        {
            int contador = 0;
            foreach (char c in cadena)
            {
                if (Char.IsDigit(c))
                {
                    contador++;
                }
            }
            return contador;
        }

        private void btnCantidadCaracteres_Click(object sender, EventArgs e)
        {
            string cadena = txtCadenaTexto.Text;
            int contadorNumeros = ContarCaracteres(cadena);
            MessageBox.Show("Cantidad de números en la cadena: " + contadorNumeros);
        }
    }

}
