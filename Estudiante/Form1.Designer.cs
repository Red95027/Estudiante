namespace Estudiante
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBLClave = new System.Windows.Forms.Label();
            this.MSKClave = new System.Windows.Forms.MaskedTextBox();
            this.BTNIngresar = new System.Windows.Forms.Button();
            this.GPBXFormulario = new System.Windows.Forms.GroupBox();
            this.LBXPrograma = new System.Windows.Forms.ListBox();
            this.CBXPrograma = new System.Windows.Forms.ComboBox();
            this.LBLPrograma = new System.Windows.Forms.Label();
            this.CKBXEgresado = new System.Windows.Forms.CheckBox();
            this.CKBXActivo = new System.Windows.Forms.CheckBox();
            this.LBLEstudiante = new System.Windows.Forms.Label();
            this.MSKClave2 = new System.Windows.Forms.MaskedTextBox();
            this.LBLClave2 = new System.Windows.Forms.Label();
            this.LBLEdad = new System.Windows.Forms.Label();
            this.NUDEdad = new System.Windows.Forms.NumericUpDown();
            this.Progressbar = new System.Windows.Forms.ProgressBar();
            this.BTNAumentar = new System.Windows.Forms.Button();
            this.BTNDIsminuir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.GPBXEstadoCivil = new System.Windows.Forms.GroupBox();
            this.GPBXGenero = new System.Windows.Forms.GroupBox();
            this.RBTNSoltero = new System.Windows.Forms.RadioButton();
            this.RBTNCasado = new System.Windows.Forms.RadioButton();
            this.RBTNMasculino = new System.Windows.Forms.RadioButton();
            this.RBTNFemenino = new System.Windows.Forms.RadioButton();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GPBXFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEdad)).BeginInit();
            this.GPBXEstadoCivil.SuspendLayout();
            this.GPBXGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLClave
            // 
            this.LBLClave.AutoSize = true;
            this.LBLClave.Location = new System.Drawing.Point(12, 9);
            this.LBLClave.Name = "LBLClave";
            this.LBLClave.Size = new System.Drawing.Size(34, 13);
            this.LBLClave.TabIndex = 0;
            this.LBLClave.Text = "Clave";
            this.LBLClave.Click += new System.EventHandler(this.LBLClave_Click);
            // 
            // MSKClave
            // 
            this.MSKClave.Location = new System.Drawing.Point(52, 6);
            this.MSKClave.Name = "MSKClave";
            this.MSKClave.PasswordChar = '*';
            this.MSKClave.Size = new System.Drawing.Size(91, 20);
            this.MSKClave.TabIndex = 1;
            this.MSKClave.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MSKClave_MaskInputRejected);
            // 
            // BTNIngresar
            // 
            this.BTNIngresar.Location = new System.Drawing.Point(149, 6);
            this.BTNIngresar.Name = "BTNIngresar";
            this.BTNIngresar.Size = new System.Drawing.Size(87, 22);
            this.BTNIngresar.TabIndex = 2;
            this.BTNIngresar.Text = "Ingresar";
            this.BTNIngresar.UseVisualStyleBackColor = true;
            this.BTNIngresar.Click += new System.EventHandler(this.BTNIngresar_Click);
            // 
            // GPBXFormulario
            // 
            this.GPBXFormulario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GPBXFormulario.Controls.Add(this.pictureBox1);
            this.GPBXFormulario.Controls.Add(this.BTNSalir);
            this.GPBXFormulario.Controls.Add(this.GPBXGenero);
            this.GPBXFormulario.Controls.Add(this.GPBXEstadoCivil);
            this.GPBXFormulario.Controls.Add(this.monthCalendar1);
            this.GPBXFormulario.Controls.Add(this.dateTimePicker1);
            this.GPBXFormulario.Controls.Add(this.BTNDIsminuir);
            this.GPBXFormulario.Controls.Add(this.BTNAumentar);
            this.GPBXFormulario.Controls.Add(this.Progressbar);
            this.GPBXFormulario.Controls.Add(this.NUDEdad);
            this.GPBXFormulario.Controls.Add(this.LBLEdad);
            this.GPBXFormulario.Controls.Add(this.LBXPrograma);
            this.GPBXFormulario.Controls.Add(this.CBXPrograma);
            this.GPBXFormulario.Controls.Add(this.LBLPrograma);
            this.GPBXFormulario.Controls.Add(this.CKBXEgresado);
            this.GPBXFormulario.Controls.Add(this.CKBXActivo);
            this.GPBXFormulario.Controls.Add(this.LBLEstudiante);
            this.GPBXFormulario.Controls.Add(this.MSKClave2);
            this.GPBXFormulario.Controls.Add(this.LBLClave2);
            this.GPBXFormulario.Location = new System.Drawing.Point(12, 34);
            this.GPBXFormulario.Name = "GPBXFormulario";
            this.GPBXFormulario.Size = new System.Drawing.Size(964, 545);
            this.GPBXFormulario.TabIndex = 3;
            this.GPBXFormulario.TabStop = false;
            this.GPBXFormulario.Text = "Formulario De Datos";
            this.GPBXFormulario.Visible = false;
            this.GPBXFormulario.Enter += new System.EventHandler(this.GPBXFormulario_Enter);
            // 
            // LBXPrograma
            // 
            this.LBXPrograma.FormattingEnabled = true;
            this.LBXPrograma.Items.AddRange(new object[] {
            "Sistemas",
            "Electronica",
            "Electrica",
            "Industrial",
            "Diseño",
            "Animacion",
            "Derecho"});
            this.LBXPrograma.Location = new System.Drawing.Point(182, 101);
            this.LBXPrograma.Name = "LBXPrograma";
            this.LBXPrograma.Size = new System.Drawing.Size(84, 56);
            this.LBXPrograma.TabIndex = 8;
            this.LBXPrograma.SelectedIndexChanged += new System.EventHandler(this.LBXPrograma_SelectedIndexChanged);
            // 
            // CBXPrograma
            // 
            this.CBXPrograma.FormattingEnabled = true;
            this.CBXPrograma.Location = new System.Drawing.Point(92, 101);
            this.CBXPrograma.Name = "CBXPrograma";
            this.CBXPrograma.Size = new System.Drawing.Size(76, 21);
            this.CBXPrograma.TabIndex = 7;
            this.CBXPrograma.SelectedIndexChanged += new System.EventHandler(this.CBXPrograma_SelectedIndexChanged);
            // 
            // LBLPrograma
            // 
            this.LBLPrograma.AutoSize = true;
            this.LBLPrograma.Location = new System.Drawing.Point(34, 104);
            this.LBLPrograma.Name = "LBLPrograma";
            this.LBLPrograma.Size = new System.Drawing.Size(52, 13);
            this.LBLPrograma.TabIndex = 6;
            this.LBLPrograma.Text = "Programa";
            this.LBLPrograma.Click += new System.EventHandler(this.LBLPrograma_Click);
            // 
            // CKBXEgresado
            // 
            this.CKBXEgresado.AutoSize = true;
            this.CKBXEgresado.Location = new System.Drawing.Point(183, 66);
            this.CKBXEgresado.Name = "CKBXEgresado";
            this.CKBXEgresado.Size = new System.Drawing.Size(71, 17);
            this.CKBXEgresado.TabIndex = 5;
            this.CKBXEgresado.Text = "Egresado";
            this.CKBXEgresado.UseVisualStyleBackColor = true;
            this.CKBXEgresado.CheckedChanged += new System.EventHandler(this.CKBXEgresado_CheckedChanged);
            // 
            // CKBXActivo
            // 
            this.CKBXActivo.AutoSize = true;
            this.CKBXActivo.Location = new System.Drawing.Point(97, 66);
            this.CKBXActivo.Name = "CKBXActivo";
            this.CKBXActivo.Size = new System.Drawing.Size(56, 17);
            this.CKBXActivo.TabIndex = 4;
            this.CKBXActivo.Text = "Activo";
            this.CKBXActivo.UseVisualStyleBackColor = true;
            this.CKBXActivo.CheckedChanged += new System.EventHandler(this.CKBXActivo_CheckedChanged);
            // 
            // LBLEstudiante
            // 
            this.LBLEstudiante.AutoSize = true;
            this.LBLEstudiante.Location = new System.Drawing.Point(34, 67);
            this.LBLEstudiante.Name = "LBLEstudiante";
            this.LBLEstudiante.Size = new System.Drawing.Size(57, 13);
            this.LBLEstudiante.TabIndex = 3;
            this.LBLEstudiante.Text = "Estudiante";
            this.LBLEstudiante.Click += new System.EventHandler(this.LBLEstudiante_Click);
            // 
            // MSKClave2
            // 
            this.MSKClave2.Location = new System.Drawing.Point(74, 33);
            this.MSKClave2.Name = "MSKClave2";
            this.MSKClave2.PasswordChar = '*';
            this.MSKClave2.Size = new System.Drawing.Size(91, 20);
            this.MSKClave2.TabIndex = 2;
            this.MSKClave2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MSKClave2_MaskInputRejected);
            // 
            // LBLClave2
            // 
            this.LBLClave2.AutoSize = true;
            this.LBLClave2.Location = new System.Drawing.Point(34, 36);
            this.LBLClave2.Name = "LBLClave2";
            this.LBLClave2.Size = new System.Drawing.Size(34, 13);
            this.LBLClave2.TabIndex = 1;
            this.LBLClave2.Text = "Clave";
            this.LBLClave2.Click += new System.EventHandler(this.LBLClave2_Click);
            // 
            // LBLEdad
            // 
            this.LBLEdad.AutoSize = true;
            this.LBLEdad.Location = new System.Drawing.Point(34, 144);
            this.LBLEdad.Name = "LBLEdad";
            this.LBLEdad.Size = new System.Drawing.Size(32, 13);
            this.LBLEdad.TabIndex = 9;
            this.LBLEdad.Text = "Edad";
            this.LBLEdad.Click += new System.EventHandler(this.LBLEdad_Click);
            // 
            // NUDEdad
            // 
            this.NUDEdad.Location = new System.Drawing.Point(72, 142);
            this.NUDEdad.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDEdad.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NUDEdad.Name = "NUDEdad";
            this.NUDEdad.Size = new System.Drawing.Size(43, 20);
            this.NUDEdad.TabIndex = 10;
            this.NUDEdad.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NUDEdad.ValueChanged += new System.EventHandler(this.NUDEdad_ValueChanged);
            // 
            // Progressbar
            // 
            this.Progressbar.ForeColor = System.Drawing.Color.Green;
            this.Progressbar.Location = new System.Drawing.Point(44, 215);
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.Size = new System.Drawing.Size(210, 16);
            this.Progressbar.TabIndex = 11;
            this.Progressbar.Value = 30;
            this.Progressbar.Click += new System.EventHandler(this.Progressbar_Click);
            // 
            // BTNAumentar
            // 
            this.BTNAumentar.Location = new System.Drawing.Point(44, 187);
            this.BTNAumentar.Name = "BTNAumentar";
            this.BTNAumentar.Size = new System.Drawing.Size(87, 22);
            this.BTNAumentar.TabIndex = 4;
            this.BTNAumentar.Text = "Aumentar";
            this.BTNAumentar.UseVisualStyleBackColor = true;
            this.BTNAumentar.Click += new System.EventHandler(this.BTNAumentar_Click);
            // 
            // BTNDIsminuir
            // 
            this.BTNDIsminuir.Location = new System.Drawing.Point(167, 187);
            this.BTNDIsminuir.Name = "BTNDIsminuir";
            this.BTNDIsminuir.Size = new System.Drawing.Size(87, 22);
            this.BTNDIsminuir.TabIndex = 12;
            this.BTNDIsminuir.Text = "Disminuir";
            this.BTNDIsminuir.UseVisualStyleBackColor = true;
            this.BTNDIsminuir.Click += new System.EventHandler(this.BTNDIsminuir_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(28, 292);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // GPBXEstadoCivil
            // 
            this.GPBXEstadoCivil.Controls.Add(this.RBTNCasado);
            this.GPBXEstadoCivil.Controls.Add(this.RBTNSoltero);
            this.GPBXEstadoCivil.Location = new System.Drawing.Point(615, 21);
            this.GPBXEstadoCivil.Name = "GPBXEstadoCivil";
            this.GPBXEstadoCivil.Size = new System.Drawing.Size(313, 80);
            this.GPBXEstadoCivil.TabIndex = 15;
            this.GPBXEstadoCivil.TabStop = false;
            this.GPBXEstadoCivil.Text = "Estado Civil";
            this.GPBXEstadoCivil.Enter += new System.EventHandler(this.GPBXEstadoCivil_Enter);
            // 
            // GPBXGenero
            // 
            this.GPBXGenero.Controls.Add(this.RBTNFemenino);
            this.GPBXGenero.Controls.Add(this.RBTNMasculino);
            this.GPBXGenero.Location = new System.Drawing.Point(615, 107);
            this.GPBXGenero.Name = "GPBXGenero";
            this.GPBXGenero.Size = new System.Drawing.Size(313, 80);
            this.GPBXGenero.TabIndex = 16;
            this.GPBXGenero.TabStop = false;
            this.GPBXGenero.Text = "Sexo";
            this.GPBXGenero.Enter += new System.EventHandler(this.GPBXGenero_Enter);
            // 
            // RBTNSoltero
            // 
            this.RBTNSoltero.AutoSize = true;
            this.RBTNSoltero.Location = new System.Drawing.Point(31, 32);
            this.RBTNSoltero.Name = "RBTNSoltero";
            this.RBTNSoltero.Size = new System.Drawing.Size(58, 17);
            this.RBTNSoltero.TabIndex = 0;
            this.RBTNSoltero.TabStop = true;
            this.RBTNSoltero.Text = "Soltero";
            this.RBTNSoltero.UseVisualStyleBackColor = true;
            this.RBTNSoltero.CheckedChanged += new System.EventHandler(this.RBTNSoltero_CheckedChanged);
            // 
            // RBTNCasado
            // 
            this.RBTNCasado.AutoSize = true;
            this.RBTNCasado.Location = new System.Drawing.Point(178, 32);
            this.RBTNCasado.Name = "RBTNCasado";
            this.RBTNCasado.Size = new System.Drawing.Size(61, 17);
            this.RBTNCasado.TabIndex = 1;
            this.RBTNCasado.TabStop = true;
            this.RBTNCasado.Text = "Casado";
            this.RBTNCasado.UseVisualStyleBackColor = true;
            this.RBTNCasado.CheckedChanged += new System.EventHandler(this.RBTNCasado_CheckedChanged);
            // 
            // RBTNMasculino
            // 
            this.RBTNMasculino.AutoSize = true;
            this.RBTNMasculino.Location = new System.Drawing.Point(31, 33);
            this.RBTNMasculino.Name = "RBTNMasculino";
            this.RBTNMasculino.Size = new System.Drawing.Size(73, 17);
            this.RBTNMasculino.TabIndex = 2;
            this.RBTNMasculino.TabStop = true;
            this.RBTNMasculino.Text = "Masculino";
            this.RBTNMasculino.UseVisualStyleBackColor = true;
            this.RBTNMasculino.CheckedChanged += new System.EventHandler(this.RBTNMasculino_CheckedChanged);
            // 
            // RBTNFemenino
            // 
            this.RBTNFemenino.AutoSize = true;
            this.RBTNFemenino.Location = new System.Drawing.Point(178, 33);
            this.RBTNFemenino.Name = "RBTNFemenino";
            this.RBTNFemenino.Size = new System.Drawing.Size(71, 17);
            this.RBTNFemenino.TabIndex = 3;
            this.RBTNFemenino.TabStop = true;
            this.RBTNFemenino.Text = "Femenino";
            this.RBTNFemenino.UseVisualStyleBackColor = true;
            this.RBTNFemenino.CheckedChanged += new System.EventHandler(this.RBTNFemenino_CheckedChanged);
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(385, 457);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(165, 32);
            this.BTNSalir.TabIndex = 18;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estudiante.Properties.Resources.c_;
            this.pictureBox1.Location = new System.Drawing.Point(656, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(989, 608);
            this.Controls.Add(this.GPBXFormulario);
            this.Controls.Add(this.BTNIngresar);
            this.Controls.Add(this.MSKClave);
            this.Controls.Add(this.LBLClave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GPBXFormulario.ResumeLayout(false);
            this.GPBXFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEdad)).EndInit();
            this.GPBXEstadoCivil.ResumeLayout(false);
            this.GPBXEstadoCivil.PerformLayout();
            this.GPBXGenero.ResumeLayout(false);
            this.GPBXGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLClave;
        private System.Windows.Forms.MaskedTextBox MSKClave;
        private System.Windows.Forms.Button BTNIngresar;
        private System.Windows.Forms.GroupBox GPBXFormulario;
        private System.Windows.Forms.Label LBLClave2;
        private System.Windows.Forms.Label LBLEstudiante;
        private System.Windows.Forms.MaskedTextBox MSKClave2;
        private System.Windows.Forms.CheckBox CKBXEgresado;
        private System.Windows.Forms.CheckBox CKBXActivo;
        private System.Windows.Forms.Label LBLPrograma;
        private System.Windows.Forms.ListBox LBXPrograma;
        private System.Windows.Forms.ComboBox CBXPrograma;
        private System.Windows.Forms.Label LBLEdad;
        private System.Windows.Forms.NumericUpDown NUDEdad;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BTNDIsminuir;
        private System.Windows.Forms.Button BTNAumentar;
        private System.Windows.Forms.ProgressBar Progressbar;
        private System.Windows.Forms.GroupBox GPBXGenero;
        private System.Windows.Forms.GroupBox GPBXEstadoCivil;
        private System.Windows.Forms.RadioButton RBTNCasado;
        private System.Windows.Forms.RadioButton RBTNSoltero;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.RadioButton RBTNFemenino;
        private System.Windows.Forms.RadioButton RBTNMasculino;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

