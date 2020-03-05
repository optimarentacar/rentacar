namespace Rentacar.Interfaz.Factura
{
    partial class FormFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactura));
            this.factura = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbAyo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPrecioDia = new System.Windows.Forms.Label();
            this.pictureBoxVehiculo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbDomicilio = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.lbFechaEntrega = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbCosteDia = new System.Windows.Forms.Label();
            this.lbDias = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbPrecioTotalDias = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbTotalAcceorios = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.listViewAccesorios = new System.Windows.Forms.ListView();
            this.listViewCaracteristicas = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehiculo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // factura
            // 
            this.factura.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.factura_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.factura;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentacar.Properties.Resources.Factura;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(734, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATOS DEL VEHICULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(43, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matrícula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(62, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(56, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(75, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Año:";
            // 
            // lbMatricula
            // 
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatricula.Location = new System.Drawing.Point(119, 131);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(69, 13);
            this.lbMatricula.TabIndex = 6;
            this.lbMatricula.Text = "lbMatricula";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(119, 153);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(45, 13);
            this.lbMarca.TabIndex = 7;
            this.lbMarca.Text = "lbMarca";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(119, 178);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(50, 13);
            this.lbModelo.TabIndex = 8;
            this.lbModelo.Text = "lbModelo";
            // 
            // lbAyo
            // 
            this.lbAyo.AutoSize = true;
            this.lbAyo.Location = new System.Drawing.Point(119, 205);
            this.lbAyo.Name = "lbAyo";
            this.lbAyo.Size = new System.Drawing.Size(33, 13);
            this.lbAyo.TabIndex = 9;
            this.lbAyo.Text = "lbAyo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(298, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Costo / Día:";
            // 
            // lbPrecioDia
            // 
            this.lbPrecioDia.AutoSize = true;
            this.lbPrecioDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioDia.Location = new System.Drawing.Point(392, 205);
            this.lbPrecioDia.Name = "lbPrecioDia";
            this.lbPrecioDia.Size = new System.Drawing.Size(72, 13);
            this.lbPrecioDia.TabIndex = 11;
            this.lbPrecioDia.Text = "lbPrecioDia";
            // 
            // pictureBoxVehiculo
            // 
            this.pictureBoxVehiculo.Location = new System.Drawing.Point(571, 105);
            this.pictureBoxVehiculo.Name = "pictureBoxVehiculo";
            this.pictureBoxVehiculo.Size = new System.Drawing.Size(176, 113);
            this.pictureBoxVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVehiculo.TabIndex = 12;
            this.pictureBoxVehiculo.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(289, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Características:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(16, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(731, 10);
            this.label8.TabIndex = 15;
            // 
            // lbDomicilio
            // 
            this.lbDomicilio.AutoSize = true;
            this.lbDomicilio.Location = new System.Drawing.Point(122, 401);
            this.lbDomicilio.Name = "lbDomicilio";
            this.lbDomicilio.Size = new System.Drawing.Size(57, 13);
            this.lbDomicilio.TabIndex = 24;
            this.lbDomicilio.Text = "lbDomicilio";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(122, 379);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(57, 13);
            this.lbTelefono.TabIndex = 23;
            this.lbTelefono.Text = "lbTelefono";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(122, 357);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(52, 13);
            this.lbNombre.TabIndex = 22;
            this.lbNombre.Text = "lbNombre";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.Location = new System.Drawing.Point(122, 334);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(36, 13);
            this.lbDni.TabIndex = 21;
            this.lbDni.Text = "lbDni";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(49, 401);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Domicilio:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(50, 379);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Teléfono:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(57, 357);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Nombre:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(78, 334);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "DNI:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(19, 306);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 16);
            this.label17.TabIndex = 16;
            this.label17.Text = "DATOS DEL CLIENTE";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(19, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(731, 10);
            this.label9.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(18, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "DATOS DEL ALQUILER";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(57, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Fecha Inicio:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(26, 509);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Fecha de Entrega:";
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Location = new System.Drawing.Point(149, 484);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(70, 13);
            this.lbFechaInicio.TabIndex = 29;
            this.lbFechaInicio.Text = "lbFechaInicio";
            // 
            // lbFechaEntrega
            // 
            this.lbFechaEntrega.AutoSize = true;
            this.lbFechaEntrega.Location = new System.Drawing.Point(149, 509);
            this.lbFechaEntrega.Name = "lbFechaEntrega";
            this.lbFechaEntrega.Size = new System.Drawing.Size(82, 13);
            this.lbFechaEntrega.TabIndex = 30;
            this.lbFechaEntrega.Text = "lbFechaEntrega";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(291, 509);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Coste / Día:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(331, 484);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Días:";
            // 
            // lbCosteDia
            // 
            this.lbCosteDia.AutoSize = true;
            this.lbCosteDia.Location = new System.Drawing.Point(464, 509);
            this.lbCosteDia.Name = "lbCosteDia";
            this.lbCosteDia.Size = new System.Drawing.Size(58, 13);
            this.lbCosteDia.TabIndex = 34;
            this.lbCosteDia.Text = "lbCosteDia";
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Location = new System.Drawing.Point(375, 484);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(36, 13);
            this.lbDias.TabIndex = 33;
            this.lbDias.Text = "lbDias";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(45, 548);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 16);
            this.label20.TabIndex = 35;
            this.label20.Text = "Accesorios:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(464, 535);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "Alquiler Vehículo:";
            // 
            // lbPrecioTotalDias
            // 
            this.lbPrecioTotalDias.AutoSize = true;
            this.lbPrecioTotalDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioTotalDias.Location = new System.Drawing.Point(606, 535);
            this.lbPrecioTotalDias.Name = "lbPrecioTotalDias";
            this.lbPrecioTotalDias.Size = new System.Drawing.Size(107, 13);
            this.lbPrecioTotalDias.TabIndex = 37;
            this.lbPrecioTotalDias.Text = "lbPrecioTotalDias";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(464, 614);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Alquiler Accesorios:";
            // 
            // lbTotalAcceorios
            // 
            this.lbTotalAcceorios.AutoSize = true;
            this.lbTotalAcceorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAcceorios.Location = new System.Drawing.Point(606, 614);
            this.lbTotalAcceorios.Name = "lbTotalAcceorios";
            this.lbTotalAcceorios.Size = new System.Drawing.Size(102, 13);
            this.lbTotalAcceorios.TabIndex = 40;
            this.lbTotalAcceorios.Text = "lbTotalAcceorios";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Location = new System.Drawing.Point(467, 639);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 32);
            this.panel1.TabIndex = 41;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Blue;
            this.lbTotal.Location = new System.Drawing.Point(142, 9);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(57, 16);
            this.lbTotal.TabIndex = 43;
            this.lbTotal.Text = "lbTotal";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(3, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(133, 16);
            this.label23.TabIndex = 42;
            this.label23.Text = "IMPORTE TOTAL:";
            // 
            // listViewAccesorios
            // 
            this.listViewAccesorios.BackColor = System.Drawing.SystemColors.Menu;
            this.listViewAccesorios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAccesorios.HideSelection = false;
            this.listViewAccesorios.Location = new System.Drawing.Point(143, 551);
            this.listViewAccesorios.Name = "listViewAccesorios";
            this.listViewAccesorios.Size = new System.Drawing.Size(429, 60);
            this.listViewAccesorios.TabIndex = 42;
            this.listViewAccesorios.UseCompatibleStateImageBehavior = false;
            // 
            // listViewCaracteristicas
            // 
            this.listViewCaracteristicas.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewCaracteristicas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCaracteristicas.HideSelection = false;
            this.listViewCaracteristicas.Location = new System.Drawing.Point(392, 227);
            this.listViewCaracteristicas.Name = "listViewCaracteristicas";
            this.listViewCaracteristicas.Size = new System.Drawing.Size(248, 56);
            this.listViewCaracteristicas.TabIndex = 43;
            this.listViewCaracteristicas.UseCompatibleStateImageBehavior = false;
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 675);
            this.Controls.Add(this.listViewCaracteristicas);
            this.Controls.Add(this.listViewAccesorios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTotalAcceorios);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lbPrecioTotalDias);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lbCosteDia);
            this.Controls.Add(this.lbDias);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbFechaEntrega);
            this.Controls.Add(this.lbFechaInicio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbDomicilio);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBoxVehiculo);
            this.Controls.Add(this.lbPrecioDia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbAyo);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehiculo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument factura;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbAyo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPrecioDia;
        private System.Windows.Forms.PictureBox pictureBoxVehiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbDomicilio;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbFechaInicio;
        private System.Windows.Forms.Label lbFechaEntrega;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbCosteDia;
        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbPrecioTotalDias;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbTotalAcceorios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ListView listViewAccesorios;
        private System.Windows.Forms.ListView listViewCaracteristicas;
    }
}