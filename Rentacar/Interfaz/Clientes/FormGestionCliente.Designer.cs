namespace Rentacar.Interfaz.Clientes
{
    partial class FormGestionCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionCliente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPersonalizado1 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.labelPersonalizado2 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.labelPersonalizado3 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.labelPersonalizado4 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textNombreApellido = new System.Windows.Forms.TextBox();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.ValidarDni = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Primero = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.Siguiente = new System.Windows.Forms.Button();
            this.Ultimo = new System.Windows.Forms.Button();
            this.Añadir = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.NombreApellidos,
            this.Telefono,
            this.Domicilio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 247);
            this.dataGridView1.TabIndex = 1;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            // 
            // NombreApellidos
            // 
            this.NombreApellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreApellidos.HeaderText = "Nombre y Apellidos";
            this.NombreApellidos.Name = "NombreApellidos";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Width = 200;
            // 
            // labelPersonalizado1
            // 
            this.labelPersonalizado1.AutoSize = true;
            this.labelPersonalizado1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado1.Location = new System.Drawing.Point(12, 375);
            this.labelPersonalizado1.Name = "labelPersonalizado1";
            this.labelPersonalizado1.Size = new System.Drawing.Size(33, 16);
            this.labelPersonalizado1.TabIndex = 2;
            this.labelPersonalizado1.Text = "DNI:";
            // 
            // labelPersonalizado2
            // 
            this.labelPersonalizado2.AutoSize = true;
            this.labelPersonalizado2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado2.Location = new System.Drawing.Point(209, 374);
            this.labelPersonalizado2.Name = "labelPersonalizado2";
            this.labelPersonalizado2.Size = new System.Drawing.Size(128, 16);
            this.labelPersonalizado2.TabIndex = 3;
            this.labelPersonalizado2.Text = "Nombre y Apellidos:";
            // 
            // labelPersonalizado3
            // 
            this.labelPersonalizado3.AutoSize = true;
            this.labelPersonalizado3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado3.Location = new System.Drawing.Point(12, 429);
            this.labelPersonalizado3.Name = "labelPersonalizado3";
            this.labelPersonalizado3.Size = new System.Drawing.Size(62, 16);
            this.labelPersonalizado3.TabIndex = 4;
            this.labelPersonalizado3.Text = "Teléfono:";
            // 
            // labelPersonalizado4
            // 
            this.labelPersonalizado4.AutoSize = true;
            this.labelPersonalizado4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado4.Location = new System.Drawing.Point(209, 429);
            this.labelPersonalizado4.Name = "labelPersonalizado4";
            this.labelPersonalizado4.Size = new System.Drawing.Size(65, 16);
            this.labelPersonalizado4.TabIndex = 5;
            this.labelPersonalizado4.Text = "Domicilio:";
            // 
            // textDni
            // 
            this.textDni.Enabled = false;
            this.textDni.Location = new System.Drawing.Point(13, 395);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(139, 20);
            this.textDni.TabIndex = 6;
            // 
            // textTelefono
            // 
            this.textTelefono.Enabled = false;
            this.textTelefono.Location = new System.Drawing.Point(12, 448);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(139, 20);
            this.textTelefono.TabIndex = 7;
            // 
            // textNombreApellido
            // 
            this.textNombreApellido.Enabled = false;
            this.textNombreApellido.Location = new System.Drawing.Point(212, 395);
            this.textNombreApellido.Name = "textNombreApellido";
            this.textNombreApellido.Size = new System.Drawing.Size(261, 20);
            this.textNombreApellido.TabIndex = 8;
            // 
            // textDomicilio
            // 
            this.textDomicilio.Enabled = false;
            this.textDomicilio.Location = new System.Drawing.Point(212, 448);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(261, 20);
            this.textDomicilio.TabIndex = 9;
            // 
            // ValidarDni
            // 
            this.ValidarDni.AutoSize = true;
            this.ValidarDni.Enabled = false;
            this.ValidarDni.Location = new System.Drawing.Point(516, 395);
            this.ValidarDni.Name = "ValidarDni";
            this.ValidarDni.Size = new System.Drawing.Size(80, 17);
            this.ValidarDni.TabIndex = 10;
            this.ValidarDni.Text = "Validar DNI";
            this.ValidarDni.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(501, 429);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(553, 429);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(43, 39);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Primero
            // 
            this.Primero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Primero.BackgroundImage")));
            this.Primero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Primero.Location = new System.Drawing.Point(30, 490);
            this.Primero.Name = "Primero";
            this.Primero.Size = new System.Drawing.Size(80, 35);
            this.Primero.TabIndex = 13;
            this.Primero.UseVisualStyleBackColor = true;
            // 
            // Atras
            // 
            this.Atras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Atras.BackgroundImage")));
            this.Atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Atras.Location = new System.Drawing.Point(116, 490);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(80, 35);
            this.Atras.TabIndex = 14;
            this.Atras.UseVisualStyleBackColor = true;
            // 
            // Siguiente
            // 
            this.Siguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Siguiente.BackgroundImage")));
            this.Siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Siguiente.Location = new System.Drawing.Point(202, 490);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(80, 35);
            this.Siguiente.TabIndex = 15;
            this.Siguiente.UseVisualStyleBackColor = true;
            // 
            // Ultimo
            // 
            this.Ultimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ultimo.BackgroundImage")));
            this.Ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ultimo.Location = new System.Drawing.Point(288, 490);
            this.Ultimo.Name = "Ultimo";
            this.Ultimo.Size = new System.Drawing.Size(80, 35);
            this.Ultimo.TabIndex = 16;
            this.Ultimo.UseVisualStyleBackColor = true;
            // 
            // Añadir
            // 
            this.Añadir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Añadir.BackgroundImage")));
            this.Añadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Añadir.Location = new System.Drawing.Point(374, 490);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(80, 35);
            this.Añadir.TabIndex = 17;
            this.Añadir.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            this.Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eliminar.BackgroundImage")));
            this.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eliminar.Location = new System.Drawing.Point(460, 490);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(80, 35);
            this.Eliminar.TabIndex = 18;
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // Modificar
            // 
            this.Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Modificar.BackgroundImage")));
            this.Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Modificar.Location = new System.Drawing.Point(546, 490);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(80, 35);
            this.Modificar.TabIndex = 19;
            this.Modificar.UseVisualStyleBackColor = true;
            // 
            // FormGestionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 537);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.Ultimo);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Primero);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ValidarDni);
            this.Controls.Add(this.textDomicilio);
            this.Controls.Add(this.textNombreApellido);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.labelPersonalizado4);
            this.Controls.Add(this.labelPersonalizado3);
            this.Controls.Add(this.labelPersonalizado2);
            this.Controls.Add(this.labelPersonalizado1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGestionCliente";
            this.Text = "Alquiler de Vehículos 1.0";
            this.Load += new System.EventHandler(this.FormGestionCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private Personalizados.LabelPersonalizado labelPersonalizado1;
        private Personalizados.LabelPersonalizado labelPersonalizado2;
        private Personalizados.LabelPersonalizado labelPersonalizado3;
        private Personalizados.LabelPersonalizado labelPersonalizado4;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textNombreApellido;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.CheckBox ValidarDni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Primero;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.Button Ultimo;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Modificar;
    }
}