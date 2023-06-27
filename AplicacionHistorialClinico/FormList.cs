using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionHistorialClinico
{
    public partial class FormList : Form
    {
        List<Paciente> listaPacientes = new List<Paciente>();
        public FormList(List<Paciente> listaPacientes)
        {
            InitializeComponent();
            this.listaPacientes = listaPacientes;
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            dataGridViewPacientes.DataSource = listaPacientes;
        }

        private void dataGridViewPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPacientes.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                FormTurns formTurns = new FormTurns();
                formTurns.ShowDialog();

            }

        }
            
            
    }
}
