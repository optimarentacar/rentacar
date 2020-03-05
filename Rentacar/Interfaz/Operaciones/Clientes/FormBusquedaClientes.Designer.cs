namespace Rentacar.Interfaz.Operaciones.Clientes
{
    partial class FormBusquedaClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbDni = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbBusqueda = new System.Windows.Forms.CheckBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.columnaDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelBusqueda = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.labelClienteNoEncontrado = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentacar.Properties.Resources.BusquedaClientes;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbDni);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda por:";
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(75, 21);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(75, 20);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.Click += new System.EventHandler(this.rbNombre_Click);
            // 
            // rbDni
            // 
            this.rbDni.AutoSize = true;
            this.rbDni.Location = new System.Drawing.Point(6, 21);
            this.rbDni.Name = "rbDni";
            this.rbDni.Size = new System.Drawing.Size(49, 20);
            this.rbDni.TabIndex = 0;
            this.rbDni.TabStop = true;
            this.rbDni.Text = "DNI";
            this.rbDni.UseVisualStyleBackColor = true;
            this.rbDni.Click += new System.EventHandler(this.rbDni_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(720, 157);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.AutoSize = true;
            this.cbBusqueda.Location = new System.Drawing.Point(713, 199);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(109, 17);
            this.cbBusqueda.TabIndex = 5;
            this.cbBusqueda.Text = "Búsqueda exacta";
            this.cbBusqueda.UseVisualStyleBackColor = true;
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaDni,
            this.columnaNombre,
            this.columnaTelefono,
            this.columnaDomicilio});
            this.tabla.Location = new System.Drawing.Point(18, 239);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersVisible = false;
            this.tabla.Size = new System.Drawing.Size(804, 269);
            this.tabla.TabIndex = 6;
            // 
            // columnaDni
            // 
            this.columnaDni.HeaderText = "DNI";
            this.columnaDni.Name = "columnaDni";
            this.columnaDni.ReadOnly = true;
            this.columnaDni.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnaDni.Width = 80;
            // 
            // columnaNombre
            // 
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            this.columnaNombre.ReadOnly = true;
            this.columnaNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnaNombre.Width = 300;
            // 
            // columnaTelefono
            // 
            this.columnaTelefono.HeaderText = "Telefono";
            this.columnaTelefono.Name = "columnaTelefono";
            this.columnaTelefono.ReadOnly = true;
            this.columnaTelefono.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnaTelefono.Width = 120;
            // 
            // columnaDomicilio
            // 
            this.columnaDomicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnaDomicilio.HeaderText = "Domicilio";
            this.columnaDomicilio.Name = "columnaDomicilio";
            this.columnaDomicilio.ReadOnly = true;
            this.columnaDomicilio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // labelBusqueda
            // 
            this.labelBusqueda.AutoSize = true;
            this.labelBusqueda.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelBusqueda.Location = new System.Drawing.Point(185, 137);
            this.labelBusqueda.Name = "labelBusqueda";
            this.labelBusqueda.Size = new System.Drawing.Size(27, 16);
            this.labelBusqueda.TabIndex = 2;
            this.labelBusqueda.Text = "Dni";
            // 
            // labelClienteNoEncontrado
            // 
            this.labelClienteNoEncontrado.AutoSize = true;
            this.labelClienteNoEncontrado.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteNoEncontrado.ForeColor = System.Drawing.Color.Red;
            this.labelClienteNoEncontrado.Location = new System.Drawing.Point(184, 193);
            this.labelClienteNoEncontrado.Name = "labelClienteNoEncontrado";
            this.labelClienteNoEncontrado.Size = new System.Drawing.Size(300, 23);
            this.labelClienteNoEncontrado.TabIndex = 7;
            this.labelClienteNoEncontrado.Text = "¡No se encuentra ningún cliente!";
            this.labelClienteNoEncontrado.Visible = false;
            // 
            // FormBusquedaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 520);
            this.Controls.Add(this.labelClienteNoEncontrado);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.cbBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelBusqueda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBusquedaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler de Vehículos 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbDni;
        private Personalizados.LabelPersonalizado labelBusqueda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox cbBusqueda;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDomicilio;
        private Personalizados.LabelPersonalizado labelClienteNoEncontrado;
    }
}