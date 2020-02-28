namespace Rentacar.Interfaz.Operaciones.Vehiculos
{
    partial class FormDetallesAlquiler
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DatosVehículo = new System.Windows.Forms.GroupBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.btnCaracteristicas = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.textPlazas = new System.Windows.Forms.TextBox();
            this.textAnyo = new System.Windows.Forms.TextBox();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DatosCliente = new System.Windows.Forms.GroupBox();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DatosAlquiler = new System.Windows.Forms.GroupBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textImporteAccesorios = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textImporte = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textFechaFin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textFechaInicio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxAccesorios = new System.Windows.Forms.ListBox();
            this.listBoxCaracteristicas = new System.Windows.Forms.ListBox();
            this.labelPersonalizado1 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DatosVehículo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.DatosCliente.SuspendLayout();
            this.DatosAlquiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentacar.Properties.Resources.DetallesAlquiler;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DatosVehículo
            // 
            this.DatosVehículo.Controls.Add(this.listBoxCaracteristicas);
            this.DatosVehículo.Controls.Add(this.pictureBoxFoto);
            this.DatosVehículo.Controls.Add(this.btnCaracteristicas);
            this.DatosVehículo.Controls.Add(this.btnFoto);
            this.DatosVehículo.Controls.Add(this.textPlazas);
            this.DatosVehículo.Controls.Add(this.textAnyo);
            this.DatosVehículo.Controls.Add(this.textModelo);
            this.DatosVehículo.Controls.Add(this.textMarca);
            this.DatosVehículo.Controls.Add(this.textMatricula);
            this.DatosVehículo.Controls.Add(this.label5);
            this.DatosVehículo.Controls.Add(this.label4);
            this.DatosVehículo.Controls.Add(this.label3);
            this.DatosVehículo.Controls.Add(this.label2);
            this.DatosVehículo.Controls.Add(this.label1);
            this.DatosVehículo.Location = new System.Drawing.Point(13, 122);
            this.DatosVehículo.Name = "DatosVehículo";
            this.DatosVehículo.Size = new System.Drawing.Size(550, 267);
            this.DatosVehículo.TabIndex = 1;
            this.DatosVehículo.TabStop = false;
            this.DatosVehículo.Text = "Datos del Vehículo";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(231, 72);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(293, 165);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 12;
            this.pictureBoxFoto.TabStop = false;
            // 
            // btnCaracteristicas
            // 
            this.btnCaracteristicas.Location = new System.Drawing.Point(277, 34);
            this.btnCaracteristicas.Name = "btnCaracteristicas";
            this.btnCaracteristicas.Size = new System.Drawing.Size(84, 23);
            this.btnCaracteristicas.TabIndex = 11;
            this.btnCaracteristicas.Text = "Características";
            this.btnCaracteristicas.UseVisualStyleBackColor = true;
            this.btnCaracteristicas.Click += new System.EventHandler(this.btnCaracteristicas_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(231, 34);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(40, 23);
            this.btnFoto.TabIndex = 10;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // textPlazas
            // 
            this.textPlazas.Enabled = false;
            this.textPlazas.Location = new System.Drawing.Point(118, 217);
            this.textPlazas.Name = "textPlazas";
            this.textPlazas.Size = new System.Drawing.Size(76, 20);
            this.textPlazas.TabIndex = 9;
            // 
            // textAnyo
            // 
            this.textAnyo.Enabled = false;
            this.textAnyo.Location = new System.Drawing.Point(10, 217);
            this.textAnyo.Name = "textAnyo";
            this.textAnyo.Size = new System.Drawing.Size(76, 20);
            this.textAnyo.TabIndex = 8;
            // 
            // textModelo
            // 
            this.textModelo.Enabled = false;
            this.textModelo.Location = new System.Drawing.Point(10, 159);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(184, 20);
            this.textModelo.TabIndex = 7;
            // 
            // textMarca
            // 
            this.textMarca.Enabled = false;
            this.textMarca.Location = new System.Drawing.Point(10, 111);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(184, 20);
            this.textMarca.TabIndex = 6;
            // 
            // textMatricula
            // 
            this.textMatricula.Enabled = false;
            this.textMatricula.Location = new System.Drawing.Point(10, 50);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(130, 20);
            this.textMatricula.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plazas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula:";
            // 
            // DatosCliente
            // 
            this.DatosCliente.Controls.Add(this.textDomicilio);
            this.DatosCliente.Controls.Add(this.textTelefono);
            this.DatosCliente.Controls.Add(this.textNombre);
            this.DatosCliente.Controls.Add(this.textDni);
            this.DatosCliente.Controls.Add(this.label9);
            this.DatosCliente.Controls.Add(this.label8);
            this.DatosCliente.Controls.Add(this.label7);
            this.DatosCliente.Controls.Add(this.label6);
            this.DatosCliente.Location = new System.Drawing.Point(13, 396);
            this.DatosCliente.Name = "DatosCliente";
            this.DatosCliente.Size = new System.Drawing.Size(453, 232);
            this.DatosCliente.TabIndex = 2;
            this.DatosCliente.TabStop = false;
            this.DatosCliente.Text = "Datos Cliente";
            // 
            // textDomicilio
            // 
            this.textDomicilio.Enabled = false;
            this.textDomicilio.Location = new System.Drawing.Point(9, 194);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(409, 20);
            this.textDomicilio.TabIndex = 16;
            // 
            // textTelefono
            // 
            this.textTelefono.Enabled = false;
            this.textTelefono.Location = new System.Drawing.Point(9, 144);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(185, 20);
            this.textTelefono.TabIndex = 15;
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(10, 94);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(408, 20);
            this.textNombre.TabIndex = 14;
            // 
            // textDni
            // 
            this.textDni.Enabled = false;
            this.textDni.Location = new System.Drawing.Point(9, 42);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(185, 20);
            this.textDni.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Domicilio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre y Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "DNI";
            // 
            // DatosAlquiler
            // 
            this.DatosAlquiler.Controls.Add(this.textTotal);
            this.DatosAlquiler.Controls.Add(this.labelPersonalizado1);
            this.DatosAlquiler.Controls.Add(this.textImporteAccesorios);
            this.DatosAlquiler.Controls.Add(this.label13);
            this.DatosAlquiler.Controls.Add(this.textImporte);
            this.DatosAlquiler.Controls.Add(this.label12);
            this.DatosAlquiler.Controls.Add(this.textFechaFin);
            this.DatosAlquiler.Controls.Add(this.label11);
            this.DatosAlquiler.Controls.Add(this.textFechaInicio);
            this.DatosAlquiler.Controls.Add(this.label10);
            this.DatosAlquiler.Location = new System.Drawing.Point(569, 122);
            this.DatosAlquiler.Name = "DatosAlquiler";
            this.DatosAlquiler.Size = new System.Drawing.Size(330, 267);
            this.DatosAlquiler.TabIndex = 3;
            this.DatosAlquiler.TabStop = false;
            this.DatosAlquiler.Text = "Datos del Alquiler";
            // 
            // textTotal
            // 
            this.textTotal.Enabled = false;
            this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.Location = new System.Drawing.Point(198, 180);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(91, 22);
            this.textTotal.TabIndex = 18;
            // 
            // textImporteAccesorios
            // 
            this.textImporteAccesorios.Enabled = false;
            this.textImporteAccesorios.Location = new System.Drawing.Point(198, 122);
            this.textImporteAccesorios.Name = "textImporteAccesorios";
            this.textImporteAccesorios.Size = new System.Drawing.Size(91, 20);
            this.textImporteAccesorios.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(109, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Accesorios:";
            // 
            // textImporte
            // 
            this.textImporte.Enabled = false;
            this.textImporte.Location = new System.Drawing.Point(198, 87);
            this.textImporte.Name = "textImporte";
            this.textImporte.Size = new System.Drawing.Size(91, 20);
            this.textImporte.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Importe (8 días):";
            // 
            // textFechaFin
            // 
            this.textFechaFin.Enabled = false;
            this.textFechaFin.Location = new System.Drawing.Point(198, 31);
            this.textFechaFin.Name = "textFechaFin";
            this.textFechaFin.Size = new System.Drawing.Size(91, 20);
            this.textFechaFin.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "al";
            // 
            // textFechaInicio
            // 
            this.textFechaInicio.Enabled = false;
            this.textFechaInicio.Location = new System.Drawing.Point(80, 31);
            this.textFechaInicio.Name = "textFechaInicio";
            this.textFechaInicio.Size = new System.Drawing.Size(91, 20);
            this.textFechaInicio.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Del";
            // 
            // listBoxAccesorios
            // 
            this.listBoxAccesorios.FormattingEnabled = true;
            this.listBoxAccesorios.Location = new System.Drawing.Point(528, 409);
            this.listBoxAccesorios.Name = "listBoxAccesorios";
            this.listBoxAccesorios.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxAccesorios.Size = new System.Drawing.Size(371, 212);
            this.listBoxAccesorios.TabIndex = 4;
            // 
            // listBoxCaracteristicas
            // 
            this.listBoxCaracteristicas.FormattingEnabled = true;
            this.listBoxCaracteristicas.Location = new System.Drawing.Point(231, 82);
            this.listBoxCaracteristicas.Name = "listBoxCaracteristicas";
            this.listBoxCaracteristicas.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxCaracteristicas.Size = new System.Drawing.Size(293, 147);
            this.listBoxCaracteristicas.TabIndex = 13;
            this.listBoxCaracteristicas.Visible = false;
            // 
            // labelPersonalizado1
            // 
            this.labelPersonalizado1.AutoSize = true;
            this.labelPersonalizado1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonalizado1.Location = new System.Drawing.Point(54, 182);
            this.labelPersonalizado1.Name = "labelPersonalizado1";
            this.labelPersonalizado1.Size = new System.Drawing.Size(115, 16);
            this.labelPersonalizado1.TabIndex = 17;
            this.labelPersonalizado1.Text = "IMPORTE TOTAL:";
            // 
            // FormDetallesAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 640);
            this.Controls.Add(this.listBoxAccesorios);
            this.Controls.Add(this.DatosAlquiler);
            this.Controls.Add(this.DatosCliente);
            this.Controls.Add(this.DatosVehículo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormDetallesAlquiler";
            this.Text = "Alquiler de Vehículos 1.0";
            this.Load += new System.EventHandler(this.FormDetallesAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DatosVehículo.ResumeLayout(false);
            this.DatosVehículo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.DatosCliente.ResumeLayout(false);
            this.DatosCliente.PerformLayout();
            this.DatosAlquiler.ResumeLayout(false);
            this.DatosAlquiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox DatosVehículo;
        private System.Windows.Forms.TextBox textPlazas;
        private System.Windows.Forms.TextBox textAnyo;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox DatosCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox DatosAlquiler;
        private System.Windows.Forms.TextBox textTotal;
        private Personalizados.LabelPersonalizado labelPersonalizado1;
        private System.Windows.Forms.TextBox textImporteAccesorios;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textImporte;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textFechaFin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textFechaInicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnCaracteristicas;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.ListBox listBoxAccesorios;
        private System.Windows.Forms.ListBox listBoxCaracteristicas;
    }
}