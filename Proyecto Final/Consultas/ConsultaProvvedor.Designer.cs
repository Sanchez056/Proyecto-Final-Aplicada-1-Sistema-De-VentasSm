namespace ProyectoFinal_Aplicada1.Consultas
{
    partial class ConsultaProvvedor
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
            this.ConsultaProveedorlabel = new System.Windows.Forms.Label();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.ConsultaProveedoressdataGridView = new System.Windows.Forms.DataGridView();
            this.Desdelabel = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.Hastalabel = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicke = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaProveedoressdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaProveedorlabel
            // 
            this.ConsultaProveedorlabel.AutoSize = true;
            this.ConsultaProveedorlabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultaProveedorlabel.Location = new System.Drawing.Point(132, 9);
            this.ConsultaProveedorlabel.Name = "ConsultaProveedorlabel";
            this.ConsultaProveedorlabel.Size = new System.Drawing.Size(371, 40);
            this.ConsultaProveedorlabel.TabIndex = 104;
            this.ConsultaProveedorlabel.Text = "Consulta De Proveedores";
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.AutoSize = true;
            this.Imprimirbutton.ForeColor = System.Drawing.Color.Black;
            this.Imprimirbutton.Location = new System.Drawing.Point(15, 389);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(93, 65);
            this.Imprimirbutton.TabIndex = 103;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // ConsultaProveedoressdataGridView
            // 
            this.ConsultaProveedoressdataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultaProveedoressdataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConsultaProveedoressdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaProveedoressdataGridView.GridColor = System.Drawing.Color.DarkRed;
            this.ConsultaProveedoressdataGridView.Location = new System.Drawing.Point(15, 172);
            this.ConsultaProveedoressdataGridView.Name = "ConsultaProveedoressdataGridView";
            this.ConsultaProveedoressdataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ConsultaProveedoressdataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Navy;
            this.ConsultaProveedoressdataGridView.Size = new System.Drawing.Size(546, 195);
            this.ConsultaProveedoressdataGridView.TabIndex = 102;
            // 
            // Desdelabel
            // 
            this.Desdelabel.AutoSize = true;
            this.Desdelabel.Location = new System.Drawing.Point(29, 145);
            this.Desdelabel.Name = "Desdelabel";
            this.Desdelabel.Size = new System.Drawing.Size(38, 13);
            this.Desdelabel.TabIndex = 101;
            this.Desdelabel.Text = "Desde";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.ForeColor = System.Drawing.Color.Black;
            this.Buscarbutton.Location = new System.Drawing.Point(443, 73);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(95, 53);
            this.Buscarbutton.TabIndex = 100;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(193, 103);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(244, 20);
            this.FiltrotextBox.TabIndex = 99;
            // 
            // Hastalabel
            // 
            this.Hastalabel.AutoSize = true;
            this.Hastalabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hastalabel.Location = new System.Drawing.Point(190, 145);
            this.Hastalabel.Name = "Hastalabel";
            this.Hastalabel.Size = new System.Drawing.Size(36, 15);
            this.Hastalabel.TabIndex = 98;
            this.Hastalabel.Text = "Hasta";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(242, 145);
            this.HastadateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(112, 22);
            this.HastadateTimePicker.TabIndex = 97;
            // 
            // DesdeDateTimePicke
            // 
            this.DesdeDateTimePicke.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicke.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicke.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicke.Location = new System.Drawing.Point(72, 141);
            this.DesdeDateTimePicke.Margin = new System.Windows.Forms.Padding(2);
            this.DesdeDateTimePicke.Name = "DesdeDateTimePicke";
            this.DesdeDateTimePicke.Size = new System.Drawing.Size(114, 22);
            this.DesdeDateTimePicke.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Filtrar";
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Location = new System.Drawing.Point(65, 102);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrarcomboBox.TabIndex = 94;
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // ConsultaProvvedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(573, 466);
            this.Controls.Add(this.ConsultaProveedorlabel);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.ConsultaProveedoressdataGridView);
            this.Controls.Add(this.Desdelabel);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.Hastalabel);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Name = "ConsultaProvvedor";
            this.Text = "ConsultaProvvedor";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaProveedoressdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConsultaProveedorlabel;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.DataGridView ConsultaProveedoressdataGridView;
        private System.Windows.Forms.Label Desdelabel;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Label Hastalabel;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
    }
}