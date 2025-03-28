using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorioderepaso
{
    public partial class FormEmpleado: System.Windows.Forms.Form
    {
        List<Empleado> empleados = new List<Empleado>();
        public FormEmpleado()
        {
            InitializeComponent();
        }
        private void Mostrar()
        {
            EmpleadoArchivo empleadoArchivo = new EmpleadoArchivo();
            empleados = empleadoArchivo.Leer("../../Empleados.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleados;
            dataGridView1.Refresh();



        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            Mostrar();

        }

        private void numericUpDownEmpleado_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //1) Crear el objeto Empleado
            Empleado empleado = new Empleado();

            //2) Ingresarle datos al objeto
            empleado.NoEmpleado = Convert.ToInt16(numericUpDownEmpleado.Value);
            empleado.Nombre = txtNombre.Text;
            empleado.SueldoHora = Convert.ToDecimal(maskedTxtSueldo.Text);

            //3) Insertar el objeto a la lista
            empleados.Add(empleado);

            //4) Crear un objeto Empleado Archivos
            EmpleadoArchivo empleadoArchivo = new EmpleadoArchivo();

            //5) Llamar al metoda grabar
            empleadoArchivo.Guardar("../../Empleados.json", empleados);

            Mostrar();

            txtNombre.Clear();
            maskedTxtSueldo.Clear();

        }
       

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            FormAsistencia formAsistencia = new FormAsistencia();
            formAsistencia.Show();

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();

        }
    }
}
