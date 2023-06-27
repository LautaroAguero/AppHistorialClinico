using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionHistorialClinico
{
    public partial class FormRemove : Form
    {
        List<Paciente> listaPacientes;
        Paciente pacienteEncontrado;
        int parametroBusqueda;

        public FormRemove(List<Paciente> listaPacientes)
        {
            InitializeComponent();
            this.listaPacientes = listaPacientes;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            parametroBusqueda = int.Parse(txtBusqueda.Text);

            pacienteEncontrado = listaPacientes.Find(paciente => paciente.dni == parametroBusqueda);

            if (pacienteEncontrado != null)
            {
                txtNombre.Text = pacienteEncontrado.nombre;
                txtApellido.Text = pacienteEncontrado.apellido;
                txtDireccion.Text = pacienteEncontrado.direccion;
                txtTelefono.Text = pacienteEncontrado.telefono;
                txtMail.Text = pacienteEncontrado.email;
            }
            else
            {
                MessageBox.Show("Paciente no encotrado");

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = listaPacientes.FindIndex(paciente => paciente.dni == parametroBusqueda);

            if (index != -1)
            {
                listaPacientes.RemoveAt(index);
                MessageBox.Show("Usuario Eliminado Correctamente!");
            }
            else {
                MessageBox.Show("Error en la eliminacion!");
            }        
            
            
        }

        public List<Paciente> GetPacientes()
        {
            return listaPacientes;
        }
    }
}
