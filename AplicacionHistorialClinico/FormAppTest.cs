using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AplicacionHistorialClinico
{
    public partial class FormAppTest : Form
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Paciente>));
        List<Paciente> listaPacientes;

        public FormAppTest()
        {
            InitializeComponent();
        }

        private void FormAppTest_Load(object sender, EventArgs e)
        {
            try
            {

                FileStream stream = new FileStream("Pacientes.xml", FileMode.Open);
                listaPacientes = (List<Paciente>)serializer.Deserialize(stream);
                stream.Close();
            }
            catch (FileNotFoundException)
            {
                
                listaPacientes = new List<Paciente>();
            }
            catch (InvalidOperationException)
            {
                
                listaPacientes = new List<Paciente>();
            }
        }



        private void btnCrear_click(object sender, EventArgs e)
        {
            FormCreate formCreate = new FormCreate();
            
            DialogResult resultado = formCreate.ShowDialog();
            
            if (resultado == DialogResult.OK)
            {
                Paciente nuevoPaciente = formCreate.GetPaciente();
                listaPacientes.Add(nuevoPaciente);
                FileStream stream = new FileStream("pacientes.xml", FileMode.Create);
                serializer.Serialize(stream, listaPacientes);
                stream.Close();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (listaPacientes.Count == 0)
            {
                MessageBox.Show("La lista de clientes está vacía.");
            }
            else
            {
                FormList formList = new FormList(listaPacientes);
                formList.ShowDialog();
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listaPacientes.Count == 0)
            {
                MessageBox.Show("La lista de clientes está vacía.");
            }
            else {
                FormUpdate formUpdate = new FormUpdate(listaPacientes);
                DialogResult result = formUpdate.ShowDialog();

                if (result == DialogResult.OK) {
                    listaPacientes = formUpdate.GetPacientes();
                    FileStream stream = new FileStream("pacientes.xml", FileMode.Create);
                    serializer.Serialize(stream, listaPacientes);
                    stream.Close();
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listaPacientes.Count == 0)
            {
                MessageBox.Show("La lista de clientes está vacía.");
            }
            else
            {
                FormRemove formRemove = new FormRemove(listaPacientes);
                DialogResult result = formRemove.ShowDialog();

                if (result == DialogResult.OK)
                {
                    listaPacientes = formRemove.GetPacientes();
                    FileStream stream = new FileStream("pacientes.xml", FileMode.Create);
                    serializer.Serialize(stream, listaPacientes);
                    stream.Close();
                }
            }

        }
    }
}
