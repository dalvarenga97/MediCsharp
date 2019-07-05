namespace InterfazMediCsharp
{
    partial class frmReceta
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
            this.gpbMedicamento = new System.Windows.Forms.GroupBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarReceta = new System.Windows.Forms.Button();
            this.btnAgregarReceta = new System.Windows.Forms.Button();
            this.dtgDetalleReceta = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbMedicamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpbMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbMedicamento
            // 
            this.gpbMedicamento.BackColor = System.Drawing.Color.Transparent;
            this.gpbMedicamento.Controls.Add(this.cmbPaciente);
            this.gpbMedicamento.Controls.Add(this.label1);
            this.gpbMedicamento.Controls.Add(this.label3);
            this.gpbMedicamento.Controls.Add(this.btnEliminarReceta);
            this.gpbMedicamento.Controls.Add(this.btnAgregarReceta);
            this.gpbMedicamento.Controls.Add(this.dtgDetalleReceta);
            this.gpbMedicamento.Controls.Add(this.txtCantidad);
            this.gpbMedicamento.Controls.Add(this.label11);
            this.gpbMedicamento.Controls.Add(this.label13);
            this.gpbMedicamento.Controls.Add(this.cmbMedicamento);
            this.gpbMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMedicamento.Location = new System.Drawing.Point(105, 54);
            this.gpbMedicamento.Name = "gpbMedicamento";
            this.gpbMedicamento.Size = new System.Drawing.Size(435, 402);
            this.gpbMedicamento.TabIndex = 17;
            this.gpbMedicamento.TabStop = false;
            this.gpbMedicamento.Text = "Receta";
            this.gpbMedicamento.Enter += new System.EventHandler(this.gpbMedicamento_Enter);
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(156, 23);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(148, 24);
            this.cmbPaciente.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 29;
            // 
            // btnEliminarReceta
            // 
            this.btnEliminarReceta.Location = new System.Drawing.Point(220, 199);
            this.btnEliminarReceta.Name = "btnEliminarReceta";
            this.btnEliminarReceta.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarReceta.TabIndex = 28;
            this.btnEliminarReceta.Text = "Eliminar";
            this.btnEliminarReceta.UseVisualStyleBackColor = true;
            this.btnEliminarReceta.Click += new System.EventHandler(this.btnEliminarReceta_Click);
            // 
            // btnAgregarReceta
            // 
            this.btnAgregarReceta.Location = new System.Drawing.Point(99, 199);
            this.btnAgregarReceta.Name = "btnAgregarReceta";
            this.btnAgregarReceta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarReceta.TabIndex = 27;
            this.btnAgregarReceta.Text = "Agregar";
            this.btnAgregarReceta.UseVisualStyleBackColor = true;
            this.btnAgregarReceta.Click += new System.EventHandler(this.btnAgregarReceta_Click);
            // 
            // dtgDetalleReceta
            // 
            this.dtgDetalleReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleReceta.Location = new System.Drawing.Point(35, 242);
            this.dtgDetalleReceta.Name = "dtgDetalleReceta";
            this.dtgDetalleReceta.Size = new System.Drawing.Size(356, 151);
            this.dtgDetalleReceta.TabIndex = 26;
            this.dtgDetalleReceta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalleMedicamento_CellContentClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(156, 136);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(148, 22);
            this.txtCantidad.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Cantidad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Medicamento:";
            // 
            // cmbMedicamento
            // 
            this.cmbMedicamento.FormattingEnabled = true;
            this.cmbMedicamento.Location = new System.Drawing.Point(156, 73);
            this.cmbMedicamento.Name = "cmbMedicamento";
            this.cmbMedicamento.Size = new System.Drawing.Size(148, 24);
            this.cmbMedicamento.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(255, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Receta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(325, 490);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Cancelar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(232, 490);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfazMediCsharp.Properties.Resources.PARA_FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 551);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpbMedicamento);
            this.Name = "frmReceta";
            this.Text = "Receta";
            this.Load += new System.EventHandler(this.frmReceta_Load);
            this.gpbMedicamento.ResumeLayout(false);
            this.gpbMedicamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMedicamento;
        private System.Windows.Forms.DataGridView dtgDetalleReceta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbMedicamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Button btnEliminarReceta;
        private System.Windows.Forms.Button btnAgregarReceta;
    }
}