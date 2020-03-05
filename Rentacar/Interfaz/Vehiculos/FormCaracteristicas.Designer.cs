namespace Rentacar.Interfaz.Vehiculos
{
    partial class FormCaracteristicas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxTodas = new System.Windows.Forms.ListBox();
            this.btnCaracteristicas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxVehiculo = new System.Windows.Forms.ListBox();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxTodas);
            this.groupBox1.Controls.Add(this.btnCaracteristicas);
            this.groupBox1.Location = new System.Drawing.Point(13, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Todas";
            // 
            // listBoxTodas
            // 
            this.listBoxTodas.FormattingEnabled = true;
            this.listBoxTodas.Location = new System.Drawing.Point(17, 37);
            this.listBoxTodas.Name = "listBoxTodas";
            this.listBoxTodas.Size = new System.Drawing.Size(215, 134);
            this.listBoxTodas.TabIndex = 2;
            // 
            // btnCaracteristicas
            // 
            this.btnCaracteristicas.Image = global::Rentacar.Properties.Resources.Guardar;
            this.btnCaracteristicas.Location = new System.Drawing.Point(197, 177);
            this.btnCaracteristicas.Name = "btnCaracteristicas";
            this.btnCaracteristicas.Size = new System.Drawing.Size(35, 38);
            this.btnCaracteristicas.TabIndex = 1;
            this.btnCaracteristicas.UseVisualStyleBackColor = true;
            this.btnCaracteristicas.Click += new System.EventHandler(this.btnCaracteristicas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxVehiculo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(349, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 221);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matrícula: ";
            // 
            // listBoxVehiculo
            // 
            this.listBoxVehiculo.FormattingEnabled = true;
            this.listBoxVehiculo.ItemHeight = 16;
            this.listBoxVehiculo.Location = new System.Drawing.Point(19, 37);
            this.listBoxVehiculo.Name = "listBoxVehiculo";
            this.listBoxVehiculo.Size = new System.Drawing.Size(202, 132);
            this.listBoxVehiculo.TabIndex = 0;
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Image = global::Rentacar.Properties.Resources.FlechaIzquierda;
            this.btnIzquierda.Location = new System.Drawing.Point(268, 233);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 44);
            this.btnIzquierda.TabIndex = 4;
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Image = global::Rentacar.Properties.Resources.FlechaDerecha;
            this.btnDerecha.Location = new System.Drawing.Point(268, 184);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 43);
            this.btnDerecha.TabIndex = 3;
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentacar.Properties.Resources.CaracteristicasVehiculo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormCaracteristicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 364);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCaracteristicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler de Vehiculos 1.0";
            this.Load += new System.EventHandler(this.FormCaracteristicas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnCaracteristicas;
        private System.Windows.Forms.ListBox listBoxTodas;
        private System.Windows.Forms.ListBox listBoxVehiculo;
    }
}