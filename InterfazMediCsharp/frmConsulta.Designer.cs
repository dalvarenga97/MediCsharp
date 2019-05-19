namespace InterfazMediCsharp
{
    partial class frmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCIpaciente = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbCritico = new System.Windows.Forms.RadioButton();
            this.rdbGrave = new System.Windows.Forms.RadioButton();
            this.rdbLeve = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNombreDoctor = new System.Windows.Forms.ComboBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtNumeroConsulta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMedicamento = new System.Windows.Forms.ComboBox();
            this.gpbMedicamento = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgDetalleMedicamento = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lstconsultas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(492, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "Consulta";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(475, 547);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(324, 547);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(175, 547);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(21, 547);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpHoraFin);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmbCIpaciente);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.rdbCritico);
            this.groupBox1.Controls.Add(this.rdbGrave);
            this.groupBox1.Controls.Add(this.rdbLeve);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpHoraInicio);
            this.groupBox1.Controls.Add(this.cmbSucursal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbNombreDoctor);
            this.groupBox1.Controls.Add(this.txtDiagnostico);
            this.groupBox1.Controls.Add(this.txtNombrePaciente);
            this.groupBox1.Controls.Add(this.txtNumeroConsulta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(567, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(541, 379);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(387, 243);
            this.dtpHoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(116, 26);
            this.dtpHoraFin.TabIndex = 27;
            this.dtpHoraFin.Value = new System.DateTime(2019, 5, 8, 10, 11, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(269, 244);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Horario Fin:";
            // 
            // cmbCIpaciente
            // 
            this.cmbCIpaciente.FormattingEnabled = true;
            this.cmbCIpaciente.Location = new System.Drawing.Point(159, 110);
            this.cmbCIpaciente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCIpaciente.Name = "cmbCIpaciente";
            this.cmbCIpaciente.Size = new System.Drawing.Size(217, 28);
            this.cmbCIpaciente.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::InterfazMediCsharp.Properties.Resources.para_consulta;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(387, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 150);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // rdbCritico
            // 
            this.rdbCritico.AutoSize = true;
            this.rdbCritico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCritico.Location = new System.Drawing.Point(324, 342);
            this.rdbCritico.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCritico.Name = "rdbCritico";
            this.rdbCritico.Size = new System.Drawing.Size(75, 21);
            this.rdbCritico.TabIndex = 11;
            this.rdbCritico.TabStop = true;
            this.rdbCritico.Text = "Critico";
            this.rdbCritico.UseVisualStyleBackColor = true;
            // 
            // rdbGrave
            // 
            this.rdbGrave.AutoSize = true;
            this.rdbGrave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGrave.Location = new System.Drawing.Point(243, 342);
            this.rdbGrave.Margin = new System.Windows.Forms.Padding(4);
            this.rdbGrave.Name = "rdbGrave";
            this.rdbGrave.Size = new System.Drawing.Size(73, 21);
            this.rdbGrave.TabIndex = 10;
            this.rdbGrave.TabStop = true;
            this.rdbGrave.Text = "Grave";
            this.rdbGrave.UseVisualStyleBackColor = true;
            // 
            // rdbLeve
            // 
            this.rdbLeve.AutoSize = true;
            this.rdbLeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLeve.Location = new System.Drawing.Point(148, 342);
            this.rdbLeve.Margin = new System.Windows.Forms.Padding(4);
            this.rdbLeve.Name = "rdbLeve";
            this.rdbLeve.Size = new System.Drawing.Size(64, 21);
            this.rdbLeve.TabIndex = 9;
            this.rdbLeve.TabStop = true;
            this.rdbLeve.Text = "Leve";
            this.rdbLeve.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 342);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tipo Urgencia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 249);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 21;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(145, 244);
            this.dtpHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(116, 26);
            this.dtpHoraInicio.TabIndex = 6;
            this.dtpHoraInicio.Value = new System.DateTime(2019, 5, 8, 10, 11, 0, 0);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(99, 205);
            this.cmbSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(217, 28);
            this.cmbSucursal.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cedula Paciente:";
            // 
            // cmbNombreDoctor
            // 
            this.cmbNombreDoctor.FormattingEnabled = true;
            this.cmbNombreDoctor.Location = new System.Drawing.Point(159, 70);
            this.cmbNombreDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNombreDoctor.Name = "cmbNombreDoctor";
            this.cmbNombreDoctor.Size = new System.Drawing.Size(217, 28);
            this.cmbNombreDoctor.TabIndex = 2;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(129, 302);
            this.txtDiagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(395, 26);
            this.txtDiagnostico.TabIndex = 8;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(159, 156);
            this.txtNombrePaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(219, 26);
            this.txtNombrePaciente.TabIndex = 4;
            // 
            // txtNumeroConsulta
            // 
            this.txtNumeroConsulta.Location = new System.Drawing.Point(176, 36);
            this.txtNumeroConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroConsulta.Name = "txtNumeroConsulta";
            this.txtNumeroConsulta.Size = new System.Drawing.Size(56, 26);
            this.txtNumeroConsulta.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 302);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Diagnostico:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nombre Paciente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sucursal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Horario Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero Consulta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Doctor:";
            // 
            // cmbMedicamento
            // 
            this.cmbMedicamento.FormattingEnabled = true;
            this.cmbMedicamento.Location = new System.Drawing.Point(169, 27);
            this.cmbMedicamento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMedicamento.Name = "cmbMedicamento";
            this.cmbMedicamento.Size = new System.Drawing.Size(166, 28);
            this.cmbMedicamento.TabIndex = 7;
            // 
            // gpbMedicamento
            // 
            this.gpbMedicamento.BackColor = System.Drawing.Color.Transparent;
            this.gpbMedicamento.Controls.Add(this.button1);
            this.gpbMedicamento.Controls.Add(this.button2);
            this.gpbMedicamento.Controls.Add(this.dtgDetalleMedicamento);
            this.gpbMedicamento.Controls.Add(this.txtCantidad);
            this.gpbMedicamento.Controls.Add(this.label11);
            this.gpbMedicamento.Controls.Add(this.label13);
            this.gpbMedicamento.Controls.Add(this.cmbMedicamento);
            this.gpbMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMedicamento.Location = new System.Drawing.Point(16, 76);
            this.gpbMedicamento.Margin = new System.Windows.Forms.Padding(4);
            this.gpbMedicamento.Name = "gpbMedicamento";
            this.gpbMedicamento.Padding = new System.Windows.Forms.Padding(4);
            this.gpbMedicamento.Size = new System.Drawing.Size(537, 394);
            this.gpbMedicamento.TabIndex = 16;
            this.gpbMedicamento.TabStop = false;
            this.gpbMedicamento.Text = "Receta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 28;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 134);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtgDetalleMedicamento
            // 
            this.dtgDetalleMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleMedicamento.Location = new System.Drawing.Point(25, 177);
            this.dtgDetalleMedicamento.Margin = new System.Windows.Forms.Padding(4);
            this.dtgDetalleMedicamento.Name = "dtgDetalleMedicamento";
            this.dtgDetalleMedicamento.Size = new System.Drawing.Size(475, 199);
            this.dtgDetalleMedicamento.TabIndex = 26;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(127, 70);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(131, 26);
            this.txtCantidad.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Cantidad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Medicamento:";
            // 
            // lstconsultas
            // 
            this.lstconsultas.FormattingEnabled = true;
            this.lstconsultas.ItemHeight = 16;
            this.lstconsultas.Location = new System.Drawing.Point(681, 475);
            this.lstconsultas.Name = "lstconsultas";
            this.lstconsultas.Size = new System.Drawing.Size(410, 132);
            this.lstconsultas.TabIndex = 17;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfazMediCsharp.Properties.Resources.PARA_FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 631);
            this.Controls.Add(this.lstconsultas);
            this.Controls.Add(this.gpbMedicamento);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Consulta:.";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbMedicamento.ResumeLayout(false);
            this.gpbMedicamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleMedicamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbNombreDoctor;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtNumeroConsulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.ComboBox cmbMedicamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbGrave;
        private System.Windows.Forms.RadioButton rdbLeve;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdbCritico;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbMedicamento;
        private System.Windows.Forms.DataGridView dtgDetalleMedicamento;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbCIpaciente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.ListBox lstconsultas;
    }
}