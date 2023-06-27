using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AplicacionHistorialClinico
{
    public partial class FormCreate : Form
    {
        Paciente pacienteCreado = new Paciente();
        public FormCreate()
        {
            InitializeComponent();
        }

        private void btnEnviar_click(object sender, EventArgs e)
        {
            pacienteCreado.dni = int.Parse(txtDni.Text);
            pacienteCreado.nombre = txtNombre.Text;
            pacienteCreado.apellido = txtApellido.Text;
            pacienteCreado.direccion = txtDireccion.Text;
            pacienteCreado.telefono = txtTelefono.Text;
            pacienteCreado.email = txtEmail.Text;

            DialogResult = DialogResult.OK;

            Close();
            
        }

        public Paciente GetPaciente() {
            return pacienteCreado;
        }
    }
}
