namespace Rentacar.Interfaz.Informes
{
    partial class FormListadoDetalladoAlquileres
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
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbBarra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentacar.Properties.Resources.ListadoDetalladoAlquileres;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.AutoScroll = true;
            this.FlowLayoutPanel.Location = new System.Drawing.Point(13, 147);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(768, 483);
            this.FlowLayoutPanel.TabIndex = 1;
            // 
            // lbBarra
            // 
            this.lbBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.lbBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(143)))));
            this.lbBarra.Location = new System.Drawing.Point(12, 633);
            this.lbBarra.Name = "lbBarra";
            this.lbBarra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbBarra.Size = new System.Drawing.Size(769, 19);
            this.lbBarra.TabIndex = 3;
            this.lbBarra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormListadoDetalladoAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 659);
            this.Controls.Add(this.lbBarra);
            this.Controls.Add(this.FlowLayoutPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListadoDetalladoAlquileres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
        private System.Windows.Forms.Label lbBarra;
    }
}