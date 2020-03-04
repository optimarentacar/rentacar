namespace Rentacar.Interfaz.Informes
{
    partial class ControlListadoAlquileres
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
            this.lbDni = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.lbAlquiler = new System.Windows.Forms.Label();
            this.lbAccesorios = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.Location = new System.Drawing.Point(-3, 4);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(36, 13);
            this.lbDni.TabIndex = 0;
            this.lbDni.Text = "lbDni";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(99, 4);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(52, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "lbNombre";
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Location = new System.Drawing.Point(229, 4);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(70, 13);
            this.lbFechaInicio.TabIndex = 2;
            this.lbFechaInicio.Text = "lbFechaInicio";
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Location = new System.Drawing.Point(336, 4);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(59, 13);
            this.lbFechaFin.TabIndex = 3;
            this.lbFechaFin.Text = "lbFechaFin";
            // 
            // lbAlquiler
            // 
            this.lbAlquiler.AutoSize = true;
            this.lbAlquiler.Location = new System.Drawing.Point(420, 4);
            this.lbAlquiler.Name = "lbAlquiler";
            this.lbAlquiler.Size = new System.Drawing.Size(49, 13);
            this.lbAlquiler.TabIndex = 4;
            this.lbAlquiler.Text = "lbAlquiler";
            // 
            // lbAccesorios
            // 
            this.lbAccesorios.AutoSize = true;
            this.lbAccesorios.Location = new System.Drawing.Point(498, 4);
            this.lbAccesorios.Name = "lbAccesorios";
            this.lbAccesorios.Size = new System.Drawing.Size(67, 13);
            this.lbAccesorios.TabIndex = 5;
            this.lbAccesorios.Text = "lbAccesorios";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(571, 4);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(46, 13);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "lbTotal";
            // 
            // ControlListadoAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbAccesorios);
            this.Controls.Add(this.lbAlquiler);
            this.Controls.Add(this.lbFechaFin);
            this.Controls.Add(this.lbFechaInicio);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDni);
            this.Name = "ControlListadoAlquileres";
            this.Size = new System.Drawing.Size(650, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbFechaInicio;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.Label lbAlquiler;
        private System.Windows.Forms.Label lbAccesorios;
        private System.Windows.Forms.Label lbTotal;
    }
}
