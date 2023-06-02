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

    public partial class FrmEmpleado : Form
    {

        private List<Empleado> lstempleados = new List<Empleado>();
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int Id;
            if (!int.TryParse(txtId.Text, out Id))
            {
                MessageBox.Show("Error: El Id debe ser un número entero.");
                return;
            }

            string Nombre = txtNombre.Text;
            string ApellidoPaterno = txtApellidoP.Text;
            string ApellidoMaterno = txtApellidoM.Text;

            DateTime FechaNacimiento;
            if (!DateTime.TryParse(txtFechaNac.Text, out FechaNacimiento))
            {
                MessageBox.Show("La fecha debe estar en formato: dd/mm/aaaa.");
                return;
            }
            Empleado empleado = new Empleado(Id, Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento);
            lstempleados.Add(empleado);

            MessageBox.Show("El empleado se ha registrado correctamente.");
            this.dtgvEmpleado.DataSource = lstempleados.ToList();
            LimpiarCampos();
        }
        private int CalcularEdad(DateTime FechaNacimiento)
        {
            int edad = DateTime.Today.Year - FechaNacimiento.Year;
            if (FechaNacimiento > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }


        private void btnEdad_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtBuscarID.Text, out id))
            {
                MessageBox.Show("Al ingresar el Id este debe ser un número entero.");
                return;
            }

            Empleado empleado = lstempleados.Find(emp => emp.Id == id);
            if (empleado != null)
            {
                int edad = CalcularEdad(empleado.FechaNacimiento);
                MessageBox.Show($"La edad del empleado con Id {id} tiene: {edad} años.");
            }
            else
            {
                MessageBox.Show("No se encuentra registrado un empleado con ese Id.");
            }
        }

        private void btnOrdenAlfabetico_Click(object sender, EventArgs e)
        {
            List<Empleado> empleadosOrdenados = lstempleados.OrderBy(emp => emp.ApellidoPaterno).ToList();
            MostrarEmpleados(empleadosOrdenados);
        }

        private void btnOrdenEdad_Click(object sender, EventArgs e)
        {
            List<Empleado> empleadosOrdenados = lstempleados.OrderBy(emp => CalcularEdad(emp.FechaNacimiento)).ToList();
            MostrarEmpleados(empleadosOrdenados);
        }

        private void MostrarEmpleados(List<Empleado> listaEmpleados)
        {
            listaEmpleados.Clear();
            foreach (Empleado empleado in listaEmpleados)
            {
                listaEmpleados.Add(empleado);
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellidoP.Text = string.Empty;
            txtApellidoM.Text = string.Empty;
            txtFechaNac.Text = string.Empty;
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            this.dtgvEmpleado.DataSource = lstempleados.ToList();
        }
    }

}


