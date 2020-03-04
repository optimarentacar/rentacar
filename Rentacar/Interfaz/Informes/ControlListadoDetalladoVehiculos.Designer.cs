namespace Rentacar.Interfaz.Informes
{
    partial class ControlListadoDetalladoVehiculos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbAyo = new System.Windows.Forms.Label();
            this.lbPlazas = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbMatricula
            // 
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatricula.ForeColor = System.Drawing.Color.Blue;
            this.lbMatricula.Location = new System.Drawing.Point(153, 15);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(59, 13);
            this.lbMatricula.TabIndex = 1;
            this.lbMatricula.Text = "Matricula";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelo.ForeColor = System.Drawing.Color.Blue;
            this.lbModelo.Location = new System.Drawing.Point(261, 15);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(42, 13);
            this.lbModelo.TabIndex = 2;
            this.lbModelo.Text = "Modelo";
            // 
            // lbAyo
            // 
            this.lbAyo.AutoSize = true;
            this.lbAyo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAyo.ForeColor = System.Drawing.Color.Blue;
            this.lbAyo.Location = new System.Drawing.Point(354, 15);
            this.lbAyo.Name = "lbAyo";
            this.lbAyo.Size = new System.Drawing.Size(26, 13);
            this.lbAyo.TabIndex = 3;
            this.lbAyo.Text = "Año";
            // 
            // lbPlazas
            // 
            this.lbPlazas.AutoSize = true;
            this.lbPlazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlazas.ForeColor = System.Drawing.Color.Blue;
            this.lbPlazas.Location = new System.Drawing.Point(440, 15);
            this.lbPlazas.Name = "lbPlazas";
            this.lbPlazas.Size = new System.Drawing.Size(38, 13);
            this.lbPlazas.TabIndex = 4;
            this.lbPlazas.Text = "Plazas";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(156, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(681, 112);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // ControlListadoDetalladoVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbPlazas);
            this.Controls.Add(this.lbAyo);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.lbMatricula);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ControlListadoDetalladoVehiculos";
            this.Size = new System.Drawing.Size(840, 146);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbAyo;
        private System.Windows.Forms.Label lbPlazas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
