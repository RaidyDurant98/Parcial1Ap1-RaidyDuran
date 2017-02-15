namespace Parcial1Ap1_RaidyDuran.UI.Consultas
{
    partial class EmpleadosConsultasForm
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
            this.ListadataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrarConsultacomboBox = new System.Windows.Forms.ComboBox();
            this.FiltrarConsultatextBox = new System.Windows.Forms.TextBox();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Filtrarbutton = new System.Windows.Forms.Button();
            this.FiltrarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ListadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltrarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadataGridView
            // 
            this.ListadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadataGridView.Location = new System.Drawing.Point(12, 120);
            this.ListadataGridView.Name = "ListadataGridView";
            this.ListadataGridView.Size = new System.Drawing.Size(349, 166);
            this.ListadataGridView.TabIndex = 0;
            // 
            // FiltrarConsultacomboBox
            // 
            this.FiltrarConsultacomboBox.FormattingEnabled = true;
            this.FiltrarConsultacomboBox.Items.AddRange(new object[] {
            "Nombre",
            "Fecha",
            "Todos"});
            this.FiltrarConsultacomboBox.Location = new System.Drawing.Point(13, 46);
            this.FiltrarConsultacomboBox.Name = "FiltrarConsultacomboBox";
            this.FiltrarConsultacomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrarConsultacomboBox.TabIndex = 1;
            // 
            // FiltrarConsultatextBox
            // 
            this.FiltrarConsultatextBox.Location = new System.Drawing.Point(154, 46);
            this.FiltrarConsultatextBox.Name = "FiltrarConsultatextBox";
            this.FiltrarConsultatextBox.Size = new System.Drawing.Size(100, 20);
            this.FiltrarConsultatextBox.TabIndex = 2;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(59, 87);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(84, 20);
            this.DesdedateTimePicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta:";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(198, 86);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(84, 20);
            this.HastadateTimePicker.TabIndex = 5;
            // 
            // Filtrarbutton
            // 
            this.Filtrarbutton.Location = new System.Drawing.Point(278, 43);
            this.Filtrarbutton.Name = "Filtrarbutton";
            this.Filtrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Filtrarbutton.TabIndex = 7;
            this.Filtrarbutton.Text = "Filtrar";
            this.Filtrarbutton.UseVisualStyleBackColor = true;
            this.Filtrarbutton.Click += new System.EventHandler(this.Filtrarbutton_Click);
            // 
            // FiltrarerrorProvider
            // 
            this.FiltrarerrorProvider.ContainerControl = this;
            // 
            // EmpleadosConsultasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 298);
            this.Controls.Add(this.Filtrarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.FiltrarConsultatextBox);
            this.Controls.Add(this.FiltrarConsultacomboBox);
            this.Controls.Add(this.ListadataGridView);
            this.Name = "EmpleadosConsultasForm";
            this.Text = "EmpleadosConsultasForm";
            this.Load += new System.EventHandler(this.EmpleadosConsultasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltrarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListadataGridView;
        private System.Windows.Forms.ComboBox FiltrarConsultacomboBox;
        private System.Windows.Forms.TextBox FiltrarConsultatextBox;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Button Filtrarbutton;
        private System.Windows.Forms.ErrorProvider FiltrarerrorProvider;
    }
}