namespace Rentacar.Interfaz.Accesorios
{
    partial class FormAlquilerAccesorios
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
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.listBoxAccesorios = new System.Windows.Forms.ListBox();
            this.listBoxAccesoriosVehiculo = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentacar.Properties.Resources.AlquilerAccesorios;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Image = global::Rentacar.Properties.Resources.FlechaDerecha;
            this.btnDerecha.Location = new System.Drawing.Point(400, 151);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 43);
            this.btnDerecha.TabIndex = 4;
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Image = global::Rentacar.Properties.Resources.FlechaIzquierda;
            this.btnIzquierda.Location = new System.Drawing.Point(400, 200);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 44);
            this.btnIzquierda.TabIndex = 5;
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // listBoxAccesorios
            // 
            this.listBoxAccesorios.FormattingEnabled = true;
            this.listBoxAccesorios.Location = new System.Drawing.Point(13, 123);
            this.listBoxAccesorios.Name = "listBoxAccesorios";
            this.listBoxAccesorios.Size = new System.Drawing.Size(381, 147);
            this.listBoxAccesorios.TabIndex = 6;
            // 
            // listBoxAccesoriosVehiculo
            // 
            this.listBoxAccesoriosVehiculo.FormattingEnabled = true;
            this.listBoxAccesoriosVehiculo.Location = new System.Drawing.Point(481, 123);
            this.listBoxAccesoriosVehiculo.Name = "listBoxAccesoriosVehiculo";
            this.listBoxAccesoriosVehiculo.Size = new System.Drawing.Size(145, 147);
            this.listBoxAccesoriosVehiculo.TabIndex = 7;
            // 
            // FormAlquilerAccesorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 279);
            this.Controls.Add(this.listBoxAccesoriosVehiculo);
            this.Controls.Add(this.listBoxAccesorios);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAlquilerAccesorios";
            this.Text = "Alquiler de Vehículos 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.ListBox listBoxAccesorios;
        private System.Windows.Forms.ListBox listBoxAccesoriosVehiculo;
    }
}