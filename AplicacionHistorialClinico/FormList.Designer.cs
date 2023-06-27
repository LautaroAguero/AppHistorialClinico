namespace AplicacionHistorialClinico
{
    partial class FormList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewPacientes = new System.Windows.Forms.DataGridView();
            this.turnos = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.AllowUserToDeleteRows = false;
            this.dataGridViewPacientes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turnos});
            this.dataGridViewPacientes.Location = new System.Drawing.Point(0, -2);
            this.dataGridViewPacientes.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.ReadOnly = true;
            this.dataGridViewPacientes.Size = new System.Drawing.Size(1357, 661);
            this.dataGridViewPacientes.TabIndex = 0;
            this.dataGridViewPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacientes_CellContentClick);
            // 
            // turnos
            // 
            this.turnos.HeaderText = "turnos";
            this.turnos.Name = "turnos";
            this.turnos.ReadOnly = true;
            this.turnos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.turnos.Text = "Agregar";
            this.turnos.UseColumnTextForButtonValue = true;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 660);
            this.Controls.Add(this.dataGridViewPacientes);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormList";
            this.Text = "FormList";
            this.Load += new System.EventHandler(this.FormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPacientes;
        private System.Windows.Forms.DataGridViewButtonColumn turnos;
    }
}