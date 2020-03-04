namespace Rentacar.Interfaz.Informes
{
    partial class ControlListadoCaracteristicas
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
            this.lbCaracteristicas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCaracteristicas
            // 
            this.lbCaracteristicas.AutoSize = true;
            this.lbCaracteristicas.Location = new System.Drawing.Point(4, 4);
            this.lbCaracteristicas.Name = "lbCaracteristicas";
            this.lbCaracteristicas.Size = new System.Drawing.Size(84, 13);
            this.lbCaracteristicas.TabIndex = 0;
            this.lbCaracteristicas.Text = "lbCaracteristicas";
            // 
            // ControlListadoCaracteristicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCaracteristicas);
            this.Name = "ControlListadoCaracteristicas";
            this.Size = new System.Drawing.Size(200, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCaracteristicas;
    }
}
