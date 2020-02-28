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
            this.dgvAccesorios = new System.Windows.Forms.DataGridView();
            this.dgvAccesoriosVehiculo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesoriosVehiculo)).BeginInit();
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
            // dgvAccesorios
            // 
            this.dgvAccesorios.AllowUserToAddRows = false;
            this.dgvAccesorios.AllowUserToDeleteRows = false;
            this.dgvAccesorios.AllowUserToResizeColumns = false;
            this.dgvAccesorios.AllowUserToResizeRows = false;
            this.dgvAccesorios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccesorios.Location = new System.Drawing.Point(13, 123);
            this.dgvAccesorios.Name = "dgvAccesorios";
            this.dgvAccesorios.Size = new System.Drawing.Size(381, 150);
            this.dgvAccesorios.TabIndex = 8;
            // 
            // dgvAccesoriosVehiculo
            // 
            this.dgvAccesoriosVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccesoriosVehiculo.Location = new System.Drawing.Point(481, 123);
            this.dgvAccesoriosVehiculo.Name = "dgvAccesoriosVehiculo";
            this.dgvAccesoriosVehiculo.Size = new System.Drawing.Size(370, 150);
            this.dgvAccesoriosVehiculo.TabIndex = 9;
            // 
            // FormAlquilerAccesorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 279);
            this.Controls.Add(this.dgvAccesoriosVehiculo);
            this.Controls.Add(this.dgvAccesorios);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAlquilerAccesorios";
            this.Text = "Alquiler de Vehículos 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesoriosVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.DataGridView dgvAccesorios;
        private System.Windows.Forms.DataGridView dgvAccesoriosVehiculo;
    }
}