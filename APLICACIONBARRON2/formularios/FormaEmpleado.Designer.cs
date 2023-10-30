namespace APLICACIONBARRON2.formularios
{
    partial class FormaEmpleado
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
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoAfiliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.comboBoxContrato = new System.Windows.Forms.ComboBox();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.textBoxNumeroA = new System.Windows.Forms.TextBox();
            this.textBoxNumeroT = new System.Windows.Forms.TextBox();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.textBoxINE = new System.Windows.Forms.TextBox();
            this.textBoxApellidoP = new System.Windows.Forms.TextBox();
            this.textBoxApellidoM = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.INE,
            this.Domicilio,
            this.noTelefono,
            this.NoAfiliacion,
            this.cargoEmpresa,
            this.Contrato,
            this.Turno});
            this.dataGridViewEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(0, 277);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(1043, 137);
            this.dataGridViewEmpleados.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.HeaderText = "Apellido Paterno";
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "Apellido Materno";
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            // 
            // INE
            // 
            this.INE.HeaderText = "INE";
            this.INE.Name = "INE";
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            // 
            // noTelefono
            // 
            this.noTelefono.HeaderText = "Número de Telefono";
            this.noTelefono.Name = "noTelefono";
            // 
            // NoAfiliacion
            // 
            this.NoAfiliacion.HeaderText = "Número de Afiliacion";
            this.NoAfiliacion.Name = "NoAfiliacion";
            // 
            // cargoEmpresa
            // 
            this.cargoEmpresa.HeaderText = "Cargo en la Empresa";
            this.cargoEmpresa.Name = "cargoEmpresa";
            // 
            // Contrato
            // 
            this.Contrato.HeaderText = "Contrato que Tiene";
            this.Contrato.Name = "Contrato";
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = global::APLICACIONBARRON2.Properties.Resources._28_asombrosos_fondos_diapositivas_Power_Point_que_puedes_descargar_gratis;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.buttonEditar);
            this.groupBox1.Controls.Add(this.buttonEliminar);
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonCerrar);
            this.groupBox1.Controls.Add(this.buttonRegresar);
            this.groupBox1.Controls.Add(this.comboBoxTurno);
            this.groupBox1.Controls.Add(this.comboBoxContrato);
            this.groupBox1.Controls.Add(this.textBoxCargo);
            this.groupBox1.Controls.Add(this.textBoxNumeroA);
            this.groupBox1.Controls.Add(this.textBoxNumeroT);
            this.groupBox1.Controls.Add(this.textBoxDomicilio);
            this.groupBox1.Controls.Add(this.textBoxINE);
            this.groupBox1.Controls.Add(this.textBoxApellidoP);
            this.groupBox1.Controls.Add(this.textBoxApellidoM);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 277);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // buttonEditar
            // 
            this.buttonEditar.AutoSize = true;
            this.buttonEditar.BackgroundImage = global::APLICACIONBARRON2.Properties.Resources.Iconos_de_Editar_Documento_para_descargar_gratis;
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditar.Location = new System.Drawing.Point(884, 144);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(57, 45);
            this.buttonEditar.TabIndex = 33;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.AutoSize = true;
            this.buttonEliminar.BackgroundImage = global::APLICACIONBARRON2.Properties.Resources.Eliminar___Icono;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEliminar.Location = new System.Drawing.Point(802, 144);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(57, 45);
            this.buttonEliminar.TabIndex = 32;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.AutoSize = true;
            this.buttonAgregar.BackgroundImage = global::APLICACIONBARRON2.Properties.Resources.Agregar_Doc___Icono;
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAgregar.Location = new System.Drawing.Point(723, 144);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(57, 45);
            this.buttonAgregar.TabIndex = 31;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(343, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Número de Afiliacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(348, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Cargo en la Empresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(720, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Contrato";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(720, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Turno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Apellido Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "INE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Domicilio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Número de Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.AutoSize = true;
            this.buttonCerrar.BackColor = System.Drawing.Color.White;
            this.buttonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCerrar.Location = new System.Drawing.Point(840, 213);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(81, 29);
            this.buttonCerrar.TabIndex = 19;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.AutoSize = true;
            this.buttonRegresar.BackColor = System.Drawing.Color.White;
            this.buttonRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRegresar.Location = new System.Drawing.Point(742, 213);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(81, 29);
            this.buttonRegresar.TabIndex = 18;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Nocturno"});
            this.comboBoxTurno.Location = new System.Drawing.Point(780, 97);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(161, 26);
            this.comboBoxTurno.TabIndex = 16;
            // 
            // comboBoxContrato
            // 
            this.comboBoxContrato.FormattingEnabled = true;
            this.comboBoxContrato.Items.AddRange(new object[] {
            "1 año",
            "2 años",
            "5 años",
            "10 años",
            "Indefinido"});
            this.comboBoxContrato.Location = new System.Drawing.Point(780, 55);
            this.comboBoxContrato.Name = "comboBoxContrato";
            this.comboBoxContrato.Size = new System.Drawing.Size(161, 26);
            this.comboBoxContrato.TabIndex = 15;
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.BackColor = System.Drawing.Color.White;
            this.textBoxCargo.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCargo.ForeColor = System.Drawing.Color.Black;
            this.textBoxCargo.Location = new System.Drawing.Point(488, 214);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(164, 29);
            this.textBoxCargo.TabIndex = 14;
            // 
            // textBoxNumeroA
            // 
            this.textBoxNumeroA.BackColor = System.Drawing.Color.White;
            this.textBoxNumeroA.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroA.ForeColor = System.Drawing.Color.Black;
            this.textBoxNumeroA.Location = new System.Drawing.Point(488, 160);
            this.textBoxNumeroA.Name = "textBoxNumeroA";
            this.textBoxNumeroA.Size = new System.Drawing.Size(164, 29);
            this.textBoxNumeroA.TabIndex = 13;
            // 
            // textBoxNumeroT
            // 
            this.textBoxNumeroT.BackColor = System.Drawing.Color.White;
            this.textBoxNumeroT.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroT.ForeColor = System.Drawing.Color.Black;
            this.textBoxNumeroT.Location = new System.Drawing.Point(488, 106);
            this.textBoxNumeroT.Name = "textBoxNumeroT";
            this.textBoxNumeroT.Size = new System.Drawing.Size(164, 29);
            this.textBoxNumeroT.TabIndex = 12;
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.BackColor = System.Drawing.Color.White;
            this.textBoxDomicilio.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDomicilio.ForeColor = System.Drawing.Color.Black;
            this.textBoxDomicilio.Location = new System.Drawing.Point(488, 55);
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(164, 29);
            this.textBoxDomicilio.TabIndex = 11;
            // 
            // textBoxINE
            // 
            this.textBoxINE.BackColor = System.Drawing.Color.White;
            this.textBoxINE.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxINE.ForeColor = System.Drawing.Color.Black;
            this.textBoxINE.Location = new System.Drawing.Point(173, 214);
            this.textBoxINE.Name = "textBoxINE";
            this.textBoxINE.Size = new System.Drawing.Size(164, 29);
            this.textBoxINE.TabIndex = 10;
            // 
            // textBoxApellidoP
            // 
            this.textBoxApellidoP.BackColor = System.Drawing.Color.White;
            this.textBoxApellidoP.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoP.ForeColor = System.Drawing.Color.Black;
            this.textBoxApellidoP.Location = new System.Drawing.Point(173, 106);
            this.textBoxApellidoP.Name = "textBoxApellidoP";
            this.textBoxApellidoP.Size = new System.Drawing.Size(164, 29);
            this.textBoxApellidoP.TabIndex = 9;
            // 
            // textBoxApellidoM
            // 
            this.textBoxApellidoM.BackColor = System.Drawing.Color.White;
            this.textBoxApellidoM.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoM.ForeColor = System.Drawing.Color.Black;
            this.textBoxApellidoM.Location = new System.Drawing.Point(173, 160);
            this.textBoxApellidoM.Name = "textBoxApellidoM";
            this.textBoxApellidoM.Size = new System.Drawing.Size(164, 29);
            this.textBoxApellidoM.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.White;
            this.textBoxNombre.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.Black;
            this.textBoxNombre.Location = new System.Drawing.Point(173, 54);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(164, 29);
            this.textBoxNombre.TabIndex = 7;
            // 
            // FormaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Name = "FormaEmpleado";
            this.Text = "FormaEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn INE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoAfiliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.ComboBox comboBoxContrato;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.TextBox textBoxNumeroA;
        private System.Windows.Forms.TextBox textBoxNumeroT;
        private System.Windows.Forms.TextBox textBoxDomicilio;
        private System.Windows.Forms.TextBox textBoxINE;
        private System.Windows.Forms.TextBox textBoxApellidoP;
        private System.Windows.Forms.TextBox textBoxApellidoM;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}