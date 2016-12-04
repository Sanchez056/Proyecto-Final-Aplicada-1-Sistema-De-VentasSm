namespace ProyectoFinal_Aplicada1.Registros
{
    partial class RegistrosProvvedores
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
            this.Editarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaIngresodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CiudadcomboBox = new System.Windows.Forms.ComboBox();
            this.CorreotextBox = new System.Windows.Forms.TextBox();
            this.FaxmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RegistroProveedorlabel = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.DirreciontextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ProveedorIdtextBox = new System.Windows.Forms.TextBox();
            this.Correolabel = new System.Windows.Forms.Label();
            this.Faxlabel = new System.Windows.Forms.Label();
            this.Telefonolabel = new System.Windows.Forms.Label();
            this.Dirreccionlabel = new System.Windows.Forms.Label();
            this.Ciudadlabel = new System.Windows.Forms.Label();
            this.NombreProveedorlabel = new System.Windows.Forms.Label();
            this.ProveedorIdlabel = new System.Windows.Forms.Label();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombreerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DirrecionerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CiudaderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TelefonoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FaxerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CorreoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirrecionerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudaderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorreoerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Editarbutton
            // 
            this.Editarbutton.ForeColor = System.Drawing.Color.Black;
            this.Editarbutton.Image = global::ProyectoFinal_Aplicada1.Properties.Resources.web_update;
            this.Editarbutton.Location = new System.Drawing.Point(245, 330);
            this.Editarbutton.Name = "Editarbutton";
            this.Editarbutton.Size = new System.Drawing.Size(116, 40);
            this.Editarbutton.TabIndex = 132;
            this.Editarbutton.Text = "Editar";
            this.Editarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Editarbutton.UseVisualStyleBackColor = true;
            this.Editarbutton.Click += new System.EventHandler(this.Editarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 131;
            this.label1.Text = "Fecha Ingreso:";
            // 
            // FechaIngresodateTimePicker
            // 
            this.FechaIngresodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngresodateTimePicker.Location = new System.Drawing.Point(275, 131);
            this.FechaIngresodateTimePicker.Name = "FechaIngresodateTimePicker";
            this.FechaIngresodateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.FechaIngresodateTimePicker.TabIndex = 130;
            // 
            // CiudadcomboBox
            // 
            this.CiudadcomboBox.FormattingEnabled = true;
            this.CiudadcomboBox.Items.AddRange(new object[] {
            "Espaillat",
            "Puerto Plata",
            "Santiago",
            "La Vega",
            "Monseñor Nouel",
            "Sánchez Ramírez",
            "Duarte",
            "Hermanas Mirabal",
            "María Trinidad Sánchez",
            "Samaná",
            "Dajabón",
            "Monte Cristi",
            "Santiago Rodríguez",
            "Valverde",
            "Azua",
            "Peravia",
            "San José de Ocoa",
            "San Cristóbal",
            "Elías Piña",
            "San Juan",
            "Enriquillo\t",
            "Barahona",
            "Bahoruco",
            "Independencia",
            "Pedernales",
            "El Seibo",
            "La Romana",
            "La Altagracia",
            "Hato Mayor",
            "Monte Plata",
            "San Pedro de Macorís",
            "Distrito Nacional",
            "Santo Domingo "});
            this.CiudadcomboBox.Location = new System.Drawing.Point(27, 286);
            this.CiudadcomboBox.Name = "CiudadcomboBox";
            this.CiudadcomboBox.Size = new System.Drawing.Size(212, 21);
            this.CiudadcomboBox.TabIndex = 129;
            // 
            // CorreotextBox
            // 
            this.CorreotextBox.Location = new System.Drawing.Point(275, 287);
            this.CorreotextBox.Name = "CorreotextBox";
            this.CorreotextBox.Size = new System.Drawing.Size(188, 20);
            this.CorreotextBox.TabIndex = 128;
            // 
            // FaxmaskedTextBox
            // 
            this.FaxmaskedTextBox.Location = new System.Drawing.Point(275, 230);
            this.FaxmaskedTextBox.Mask = "(999)000-0000";
            this.FaxmaskedTextBox.Name = "FaxmaskedTextBox";
            this.FaxmaskedTextBox.Size = new System.Drawing.Size(188, 20);
            this.FaxmaskedTextBox.TabIndex = 127;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(275, 174);
            this.TelefonomaskedTextBox.Mask = "(999)000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(188, 20);
            this.TelefonomaskedTextBox.TabIndex = 126;
            // 
            // RegistroProveedorlabel
            // 
            this.RegistroProveedorlabel.AutoSize = true;
            this.RegistroProveedorlabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroProveedorlabel.Location = new System.Drawing.Point(120, 9);
            this.RegistroProveedorlabel.Name = "RegistroProveedorlabel";
            this.RegistroProveedorlabel.Size = new System.Drawing.Size(241, 27);
            this.RegistroProveedorlabel.TabIndex = 125;
            this.RegistroProveedorlabel.Text = "Registros de Proveedor";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Buscarbutton.Image = global::ProyectoFinal_Aplicada1.Properties.Resources.search;
            this.Buscarbutton.Location = new System.Drawing.Point(149, 69);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(99, 54);
            this.Buscarbutton.TabIndex = 124;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Eliminarbutton.Image = global::ProyectoFinal_Aplicada1.Properties.Resources.cancel;
            this.Eliminarbutton.Location = new System.Drawing.Point(367, 332);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(118, 38);
            this.Eliminarbutton.TabIndex = 123;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Guardarbutton.Image = global::ProyectoFinal_Aplicada1.Properties.Resources.save;
            this.Guardarbutton.Location = new System.Drawing.Point(137, 332);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(102, 38);
            this.Guardarbutton.TabIndex = 122;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nuevobutton.Image = global::ProyectoFinal_Aplicada1.Properties.Resources._new;
            this.Nuevobutton.Location = new System.Drawing.Point(27, 332);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(101, 38);
            this.Nuevobutton.TabIndex = 121;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // DirreciontextBox
            // 
            this.DirreciontextBox.Location = new System.Drawing.Point(27, 230);
            this.DirreciontextBox.Name = "DirreciontextBox";
            this.DirreciontextBox.Size = new System.Drawing.Size(212, 20);
            this.DirreciontextBox.TabIndex = 120;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(27, 173);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(212, 20);
            this.NombretextBox.TabIndex = 119;
            // 
            // ProveedorIdtextBox
            // 
            this.ProveedorIdtextBox.Location = new System.Drawing.Point(27, 101);
            this.ProveedorIdtextBox.Name = "ProveedorIdtextBox";
            this.ProveedorIdtextBox.Size = new System.Drawing.Size(115, 20);
            this.ProveedorIdtextBox.TabIndex = 118;
            // 
            // Correolabel
            // 
            this.Correolabel.AutoSize = true;
            this.Correolabel.Location = new System.Drawing.Point(272, 268);
            this.Correolabel.Name = "Correolabel";
            this.Correolabel.Size = new System.Drawing.Size(41, 13);
            this.Correolabel.TabIndex = 117;
            this.Correolabel.Text = "Correo:";
            // 
            // Faxlabel
            // 
            this.Faxlabel.AutoSize = true;
            this.Faxlabel.Location = new System.Drawing.Point(272, 212);
            this.Faxlabel.Name = "Faxlabel";
            this.Faxlabel.Size = new System.Drawing.Size(27, 13);
            this.Faxlabel.TabIndex = 116;
            this.Faxlabel.Text = "Fax:";
            // 
            // Telefonolabel
            // 
            this.Telefonolabel.AutoSize = true;
            this.Telefonolabel.Location = new System.Drawing.Point(272, 155);
            this.Telefonolabel.Name = "Telefonolabel";
            this.Telefonolabel.Size = new System.Drawing.Size(52, 13);
            this.Telefonolabel.TabIndex = 115;
            this.Telefonolabel.Text = "Telefono:";
            // 
            // Dirreccionlabel
            // 
            this.Dirreccionlabel.AutoSize = true;
            this.Dirreccionlabel.Location = new System.Drawing.Point(24, 212);
            this.Dirreccionlabel.Name = "Dirreccionlabel";
            this.Dirreccionlabel.Size = new System.Drawing.Size(52, 13);
            this.Dirreccionlabel.TabIndex = 114;
            this.Dirreccionlabel.Text = "Dirrecion:";
            // 
            // Ciudadlabel
            // 
            this.Ciudadlabel.AutoSize = true;
            this.Ciudadlabel.Location = new System.Drawing.Point(24, 268);
            this.Ciudadlabel.Name = "Ciudadlabel";
            this.Ciudadlabel.Size = new System.Drawing.Size(43, 13);
            this.Ciudadlabel.TabIndex = 113;
            this.Ciudadlabel.Text = "Ciudad:";
            // 
            // NombreProveedorlabel
            // 
            this.NombreProveedorlabel.AutoSize = true;
            this.NombreProveedorlabel.Location = new System.Drawing.Point(24, 155);
            this.NombreProveedorlabel.Name = "NombreProveedorlabel";
            this.NombreProveedorlabel.Size = new System.Drawing.Size(99, 13);
            this.NombreProveedorlabel.TabIndex = 112;
            this.NombreProveedorlabel.Text = "Nombre Proveedor:";
            // 
            // ProveedorIdlabel
            // 
            this.ProveedorIdlabel.AutoSize = true;
            this.ProveedorIdlabel.Location = new System.Drawing.Point(24, 83);
            this.ProveedorIdlabel.Name = "ProveedorIdlabel";
            this.ProveedorIdlabel.Size = new System.Drawing.Size(71, 13);
            this.ProveedorIdlabel.TabIndex = 111;
            this.ProveedorIdlabel.Text = "Proveedor Id:";
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // NombreerrorProvider
            // 
            this.NombreerrorProvider.ContainerControl = this;
            // 
            // DirrecionerrorProvider
            // 
            this.DirrecionerrorProvider.ContainerControl = this;
            // 
            // CiudaderrorProvider
            // 
            this.CiudaderrorProvider.ContainerControl = this;
            // 
            // TelefonoerrorProvider
            // 
            this.TelefonoerrorProvider.ContainerControl = this;
            // 
            // FaxerrorProvider
            // 
            this.FaxerrorProvider.ContainerControl = this;
            // 
            // CorreoerrorProvider
            // 
            this.CorreoerrorProvider.ContainerControl = this;
            // 
            // RegistrosProvvedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 393);
            this.Controls.Add(this.Editarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaIngresodateTimePicker);
            this.Controls.Add(this.CiudadcomboBox);
            this.Controls.Add(this.CorreotextBox);
            this.Controls.Add(this.FaxmaskedTextBox);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.RegistroProveedorlabel);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.DirreciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.ProveedorIdtextBox);
            this.Controls.Add(this.Correolabel);
            this.Controls.Add(this.Faxlabel);
            this.Controls.Add(this.Telefonolabel);
            this.Controls.Add(this.Dirreccionlabel);
            this.Controls.Add(this.Ciudadlabel);
            this.Controls.Add(this.NombreProveedorlabel);
            this.Controls.Add(this.ProveedorIdlabel);
            this.Name = "RegistrosProvvedores";
            this.Text = "RegistrosProvvedores";
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirrecionerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CiudaderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorreoerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Editarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaIngresodateTimePicker;
        private System.Windows.Forms.ComboBox CiudadcomboBox;
        private System.Windows.Forms.TextBox CorreotextBox;
        private System.Windows.Forms.MaskedTextBox FaxmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.Label RegistroProveedorlabel;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.TextBox DirreciontextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox ProveedorIdtextBox;
        private System.Windows.Forms.Label Correolabel;
        private System.Windows.Forms.Label Faxlabel;
        private System.Windows.Forms.Label Telefonolabel;
        private System.Windows.Forms.Label Dirreccionlabel;
        private System.Windows.Forms.Label Ciudadlabel;
        private System.Windows.Forms.Label NombreProveedorlabel;
        private System.Windows.Forms.Label ProveedorIdlabel;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
        private System.Windows.Forms.ErrorProvider NombreerrorProvider;
        private System.Windows.Forms.ErrorProvider DirrecionerrorProvider;
        private System.Windows.Forms.ErrorProvider CiudaderrorProvider;
        private System.Windows.Forms.ErrorProvider TelefonoerrorProvider;
        private System.Windows.Forms.ErrorProvider FaxerrorProvider;
        private System.Windows.Forms.ErrorProvider CorreoerrorProvider;
    }
}