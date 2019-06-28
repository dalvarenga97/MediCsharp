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
            this.btnEliminarReceta = new System.Windows.Forms.Button();
            this.btnAgregarReceta = new System.Windows.Forms.Button();
            this.dtgDetalleMedicamento = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbMedicamento = new System.Windows.Forms.ComboBox();
            this.cmbConsulta = new System.Windows.Forms.ComboBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarReceta
            // 
            this.btnEliminarReceta.Location = new System.Drawing.Point(381, 192);
            this.btnEliminarReceta.Name = "btnEliminarReceta";
            this.btnEliminarReceta.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarReceta.TabIndex = 35;
            this.btnEliminarReceta.Text = "Eliminar";
            this.btnEliminarReceta.UseVisualStyleBackColor = true;
            this.btnEliminarReceta.Click += new System.EventHandler(this.btnEliminarReceta_Click);
            // 
            // btnAgregarReceta
            // 
            this.btnAgregarReceta.Location = new System.Drawing.Point(260, 192);
            this.btnAgregarReceta.Name = "btnAgregarReceta";
            this.btnAgregarReceta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarReceta.TabIndex = 34;
            this.btnAgregarReceta.Text = "Agregar";
            this.btnAgregarReceta.UseVisualStyleBackColor = true;
            this.btnAgregarReceta.Click += new System.EventHandler(this.btnAgregarReceta_Click);
            // 
            // dtgDetalleMedicamento
            // 
            this.dtgDetalleMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleMedicamento.Location = new System.Drawing.Point(184, 227);
            this.dtgDetalleMedicamento.Name = "dtgDetalleMedicamento";
            this.dtgDetalleMedicamento.Size = new System.Drawing.Size(356, 151);
            this.dtgDetalleMedicamento.TabIndex = 33;
            this.dtgDetalleMedicamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalleMedicamento_CellContentClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(292, 139);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(126, 20);
            this.txtCantidad.TabIndex = 31;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(181, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Cantidad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(181, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Medicamento:";
            // 
            // cmbMedicamento
            // 
            this.cmbMedicamento.FormattingEnabled = true;
            this.cmbMedicamento.Location = new System.Drawing.Point(292, 105);
            this.cmbMedicamento.Name = "cmbMedicamento";
            this.cmbMedicamento.Size = new System.Drawing.Size(126, 21);
            this.cmbMedicamento.TabIndex = 30;
            this.cmbMedicamento.SelectedIndexChanged += new System.EventHandler(this.cmbMedicamento_SelectedIndexChanged);
            // 
            // cmbConsulta
            // 
            this.cmbConsulta.FormattingEnabled = true;
            this.cmbConsulta.Location = new System.Drawing.Point(292, 78);
            this.cmbConsulta.Name = "cmbConsulta";
            this.cmbConsulta.Size = new System.Drawing.Size(126, 21);
            this.cmbConsulta.TabIndex = 36;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(181, 78);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(60, 13);
            this.lblConsulta.TabIndex = 37;
            this.lblConsulta.Text = "Consulta:";
            this.lblConsulta.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfazMediCsharp.Properties.Resources.PARA_FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 483);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.cmbConsulta);
            this.Controls.Add(this.btnEliminarReceta);
            this.Controls.Add(this.btnAgregarReceta);
            this.Controls.Add(this.dtgDetalleMedicamento);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbMedicamento);
            this.Name = "frmReceta";
            this.Text = "frmReceta";
            this.Load += new System.EventHandler(this.frmReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleMedicamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarReceta;
        private System.Windows.Forms.Button btnAgregarReceta;
        private System.Windows.Forms.DataGridView dtgDetalleMedicamento;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbMedicamento;
        private System.Windows.Forms.ComboBox cmbConsulta;
        private System.Windows.Forms.Label lblConsulta;
    }
}