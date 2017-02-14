namespace Parcial1Ap1_RaidyDuran.UI.Registros
{
    partial class EmpleadosRegistroForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label empleadoIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label sueldoLabel;
            this.empleadoIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.buscarbutton = new System.Windows.Forms.Button();
            this.NombreerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SueldoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sueldomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            empleadoIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldoerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadoIdLabel
            // 
            empleadoIdLabel.AutoSize = true;
            empleadoIdLabel.Location = new System.Drawing.Point(26, 63);
            empleadoIdLabel.Name = "empleadoIdLabel";
            empleadoIdLabel.Size = new System.Drawing.Size(69, 13);
            empleadoIdLabel.TabIndex = 1;
            empleadoIdLabel.Text = "Empleado Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(26, 89);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(26, 116);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 5;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // sueldoLabel
            // 
            sueldoLabel.AutoSize = true;
            sueldoLabel.Location = new System.Drawing.Point(26, 145);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(43, 13);
            sueldoLabel.TabIndex = 7;
            sueldoLabel.Text = "Sueldo:";
            // 
            // empleadoIdTextBox
            // 
            this.empleadoIdTextBox.Location = new System.Drawing.Point(128, 60);
            this.empleadoIdTextBox.Name = "empleadoIdTextBox";
            this.empleadoIdTextBox.Size = new System.Drawing.Size(90, 20);
            this.empleadoIdTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(128, 86);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fechaNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(128, 112);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 6;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(29, 201);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 9;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(253, 201);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(143, 201);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // buscarbutton
            // 
            this.buscarbutton.Location = new System.Drawing.Point(253, 57);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.buscarbutton.TabIndex = 12;
            this.buscarbutton.Text = "Buscar";
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.buscarbutton_Click);
            // 
            // NombreerrorProvider
            // 
            this.NombreerrorProvider.ContainerControl = this;
            // 
            // SueldoerrorProvider
            // 
            this.SueldoerrorProvider.ContainerControl = this;
            // 
            // sueldomaskedTextBox
            // 
            this.sueldomaskedTextBox.Location = new System.Drawing.Point(128, 138);
            this.sueldomaskedTextBox.Mask = "999999999999999999";
            this.sueldomaskedTextBox.Name = "sueldomaskedTextBox";
            this.sueldomaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.sueldomaskedTextBox.TabIndex = 13;
            // 
            // EmpleadosRegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.sueldomaskedTextBox);
            this.Controls.Add(this.buscarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(empleadoIdLabel);
            this.Controls.Add(this.empleadoIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(sueldoLabel);
            this.Name = "EmpleadosRegistroForm";
            this.Text = "EmpleadosRegistroForm";
            this.Load += new System.EventHandler(this.EmpleadosRegistroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldoerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox empleadoIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button buscarbutton;
        private System.Windows.Forms.ErrorProvider NombreerrorProvider;
        private System.Windows.Forms.ErrorProvider SueldoerrorProvider;
        private System.Windows.Forms.MaskedTextBox sueldomaskedTextBox;
    }
}