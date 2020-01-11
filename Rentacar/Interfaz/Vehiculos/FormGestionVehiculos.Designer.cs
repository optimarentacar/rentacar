namespace Rentacar.Interfaz.Vehiculos
{
    partial class FormGestionVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionVehiculos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TablaVehiculos = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plazas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CosteDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPersonalizado1 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.labelPersonalizado2 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.labelPersonalizado3 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.labelPersonalizado4 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.labelPersonalizado5 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.labelPersonalizado6 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textAño = new System.Windows.Forms.TextBox();
            this.textCapacidad = new System.Windows.Forms.TextBox();
            this.textCosto = new System.Windows.Forms.TextBox();
            this.FotoVehiculo = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnCaracteristicas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(982, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TablaVehiculos
            // 
            this.TablaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Marca,
            this.Modelo,
            this.Plazas,
            this.Año,
            this.CosteDia});
            this.TablaVehiculos.Location = new System.Drawing.Point(12, 141);
            this.TablaVehiculos.Name = "TablaVehiculos";
            this.TablaVehiculos.Size = new System.Drawing.Size(763, 270);
            this.TablaVehiculos.TabIndex = 1;
            this.TablaVehiculos.SelectionChanged += new System.EventHandler(this.TablaVehiculos_SelectionChanged);
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matrícula";
            this.Matricula.Name = "Matricula";
            this.Matricula.Width = 120;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Width = 150;
            // 
            // Modelo
            // 
            this.Modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Plazas
            // 
            this.Plazas.HeaderText = "Plazas";
            this.Plazas.Name = "Plazas";
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            // 
            // CosteDia
            // 
            this.CosteDia.HeaderText = "Coste / Día";
            this.CosteDia.Name = "CosteDia";
            // 
            // labelPersonalizado1
            // 
            this.labelPersonalizado1.AutoSize = true;
            this.labelPersonalizado1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado1.Location = new System.Drawing.Point(13, 428);
            this.labelPersonalizado1.Name = "labelPersonalizado1";
            this.labelPersonalizado1.Size = new System.Drawing.Size(62, 16);
            this.labelPersonalizado1.TabIndex = 2;
            this.labelPersonalizado1.Text = "Matrícula";
            // 
            // labelPersonalizado2
            // 
            this.labelPersonalizado2.AutoSize = true;
            this.labelPersonalizado2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado2.Location = new System.Drawing.Point(548, 428);
            this.labelPersonalizado2.Name = "labelPersonalizado2";
            this.labelPersonalizado2.Size = new System.Drawing.Size(70, 16);
            this.labelPersonalizado2.TabIndex = 3;
            this.labelPersonalizado2.Text = "Capacidad";
            // 
            // labelPersonalizado3
            // 
            this.labelPersonalizado3.AutoSize = true;
            this.labelPersonalizado3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado3.Location = new System.Drawing.Point(421, 428);
            this.labelPersonalizado3.Name = "labelPersonalizado3";
            this.labelPersonalizado3.Size = new System.Drawing.Size(31, 16);
            this.labelPersonalizado3.TabIndex = 4;
            this.labelPersonalizado3.Text = "Año";
            // 
            // labelPersonalizado4
            // 
            this.labelPersonalizado4.AutoSize = true;
            this.labelPersonalizado4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado4.Location = new System.Drawing.Point(144, 428);
            this.labelPersonalizado4.Name = "labelPersonalizado4";
            this.labelPersonalizado4.Size = new System.Drawing.Size(45, 16);
            this.labelPersonalizado4.TabIndex = 5;
            this.labelPersonalizado4.Text = "Marca";
            // 
            // labelPersonalizado5
            // 
            this.labelPersonalizado5.AutoSize = true;
            this.labelPersonalizado5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado5.Location = new System.Drawing.Point(293, 428);
            this.labelPersonalizado5.Name = "labelPersonalizado5";
            this.labelPersonalizado5.Size = new System.Drawing.Size(54, 16);
            this.labelPersonalizado5.TabIndex = 6;
            this.labelPersonalizado5.Text = "Modelo";
            // 
            // labelPersonalizado6
            // 
            this.labelPersonalizado6.AutoSize = true;
            this.labelPersonalizado6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado6.Location = new System.Drawing.Point(667, 428);
            this.labelPersonalizado6.Name = "labelPersonalizado6";
            this.labelPersonalizado6.Size = new System.Drawing.Size(73, 16);
            this.labelPersonalizado6.TabIndex = 7;
            this.labelPersonalizado6.Text = "Coste / Día";
            // 
            // textMatricula
            // 
            this.textMatricula.Location = new System.Drawing.Point(12, 447);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(100, 20);
            this.textMatricula.TabIndex = 8;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(147, 447);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarca.TabIndex = 9;
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(296, 447);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(100, 20);
            this.textModelo.TabIndex = 10;
            // 
            // textAño
            // 
            this.textAño.Location = new System.Drawing.Point(424, 448);
            this.textAño.Name = "textAño";
            this.textAño.Size = new System.Drawing.Size(100, 20);
            this.textAño.TabIndex = 11;
            // 
            // textCapacidad
            // 
            this.textCapacidad.Location = new System.Drawing.Point(551, 447);
            this.textCapacidad.Name = "textCapacidad";
            this.textCapacidad.Size = new System.Drawing.Size(100, 20);
            this.textCapacidad.TabIndex = 12;
            // 
            // textCosto
            // 
            this.textCosto.Location = new System.Drawing.Point(670, 447);
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(100, 20);
            this.textCosto.TabIndex = 13;
            // 
            // FotoVehiculo
            // 
            this.FotoVehiculo.Location = new System.Drawing.Point(781, 183);
            this.FotoVehiculo.Name = "FotoVehiculo";
            this.FotoVehiculo.Size = new System.Drawing.Size(213, 138);
            this.FotoVehiculo.TabIndex = 14;
            this.FotoVehiculo.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(917, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancelar.Size = new System.Drawing.Size(43, 39);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnValidar
            // 
            this.btnValidar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValidar.BackgroundImage")));
            this.btnValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidar.Enabled = false;
            this.btnValidar.Location = new System.Drawing.Point(812, 392);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnValidar.Size = new System.Drawing.Size(43, 39);
            this.btnValidar.TabIndex = 15;
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(643, 482);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 35);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(538, 482);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 35);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAñadir.BackgroundImage")));
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadir.Location = new System.Drawing.Point(433, 482);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(99, 35);
            this.btnAñadir.TabIndex = 24;
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUltimo.BackgroundImage")));
            this.btnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimo.Location = new System.Drawing.Point(328, 482);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(99, 35);
            this.btnUltimo.TabIndex = 23;
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.BackgroundImage")));
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Location = new System.Drawing.Point(223, 482);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(99, 35);
            this.btnSiguiente.TabIndex = 22;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Location = new System.Drawing.Point(118, 482);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(99, 35);
            this.btnAtras.TabIndex = 21;
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrimero.BackgroundImage")));
            this.btnPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrimero.Location = new System.Drawing.Point(13, 482);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(99, 35);
            this.btnPrimero.TabIndex = 20;
            this.btnPrimero.UseVisualStyleBackColor = true;
            // 
            // btnCaracteristicas
            // 
            this.btnCaracteristicas.Location = new System.Drawing.Point(748, 482);
            this.btnCaracteristicas.Name = "btnCaracteristicas";
            this.btnCaracteristicas.Size = new System.Drawing.Size(246, 35);
            this.btnCaracteristicas.TabIndex = 27;
            this.btnCaracteristicas.Text = "Características";
            this.btnCaracteristicas.UseVisualStyleBackColor = true;
            // 
            // FormGestionVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 533);
            this.Controls.Add(this.btnCaracteristicas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.FotoVehiculo);
            this.Controls.Add(this.textCosto);
            this.Controls.Add(this.textCapacidad);
            this.Controls.Add(this.textAño);
            this.Controls.Add(this.textModelo);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.textMatricula);
            this.Controls.Add(this.labelPersonalizado6);
            this.Controls.Add(this.labelPersonalizado5);
            this.Controls.Add(this.labelPersonalizado4);
            this.Controls.Add(this.labelPersonalizado3);
            this.Controls.Add(this.labelPersonalizado2);
            this.Controls.Add(this.labelPersonalizado1);
            this.Controls.Add(this.TablaVehiculos);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGestionVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler de Vehículos 1.0";
            this.Load += new System.EventHandler(this.FormGestionVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView TablaVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plazas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn CosteDia;
        private Personalizados.LabelPersonalizado labelPersonalizado1;
        private Personalizados.LabelPersonalizado labelPersonalizado2;
        private Personalizados.LabelPersonalizado labelPersonalizado3;
        private Personalizados.LabelPersonalizado labelPersonalizado4;
        private Personalizados.LabelPersonalizado labelPersonalizado5;
        private Personalizados.LabelPersonalizado labelPersonalizado6;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textAño;
        private System.Windows.Forms.TextBox textCapacidad;
        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.PictureBox FotoVehiculo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnCaracteristicas;
    }
}