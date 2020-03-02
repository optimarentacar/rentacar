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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalAlquileres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.FlowLayoutPanel.Size = new System.Drawing.Size(768, 545);
            this.FlowLayoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbTotalAlquileres);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Location = new System.Drawing.Point(13, 698);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 24);
            this.panel1.TabIndex = 5;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbTotal.Location = new System.Drawing.Point(626, 2);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(116, 20);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Importe Total";
            // 
            // lbTotalAlquileres
            // 
            this.lbTotalAlquileres.AutoSize = true;
            this.lbTotalAlquileres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAlquileres.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbTotalAlquileres.Location = new System.Drawing.Point(487, 2);
            this.lbTotalAlquileres.Name = "lbTotalAlquileres";
            this.lbTotalAlquileres.Size = new System.Drawing.Size(133, 20);
            this.lbTotalAlquileres.TabIndex = 1;
            this.lbTotalAlquileres.Text = "Total Alquileres";
            // 
            // FormListadoDetalladoAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FlowLayoutPanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormListadoDetalladoAlquileres";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotalAlquileres;
    }
}