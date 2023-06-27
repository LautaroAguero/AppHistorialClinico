using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionHistorialClinico
{
    public partial class FormUpdate : Form
    {
        List<Paciente> listaPacientes;
        Paciente pacienteEncontrado;
        int parametroBusqueda;
        
        public FormUpdate(List<Paciente> listaPacientes)
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int index = listaPacientes.FindIndex(paciente => paciente.dni == parametroBusqueda);

            if (index != -1)
            {
                if (pacienteEncontrado.nombre != txtNombre.Text)
                {
                    listaPacientes[index].nombre = txtNombre.Text;
                }
                if (pacienteEncontrado.apellido != txtApellido.Text)
                {
                    listaPacientes[index].apellido = txtApellido.Text;
                }
                if (pacienteEncontrado.direccion != txtDireccion.Text)
                {
                    listaPacientes[index].direccion = txtDireccion.Text;
                }
                if (pacienteEncontrado.telefono != txtTelefono.Text)
                {
                    listaPacientes[index].telefono = txtTelefono.Text;
                }
                if (pacienteEncontrado.email != txtMail.Text)
                {
                    listaPacientes[index].email = txtMail.Text;
                }

                MessageBox.Show("Usuario Actualizado Correctamente!");
            }
            else
            {
                MessageBox.Show("Error en la actualizacion!");
            }            

            DialogResult = DialogResult.OK;

            Close();
        }

        public List<Paciente> GetPacientes()
        {
            return listaPacientes;
        }
    }
}
