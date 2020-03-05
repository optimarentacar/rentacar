namespace Rentacar.Interfaz.Operaciones.Vehiculos
{
    partial class FormBusquedaVehiculosPorMatricula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.columaMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPlazas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCoste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPersonalizado1 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentacar.Properties.Resources.BusquedaVehiculosPorMatricula;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(963, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(91, 136);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(166, 20);
            this.tbMatricula.TabIndex = 2;
            this.tbMatricula.TextChanged += new System.EventHandler(this.tbMatricula_TextChanged);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(12, 173);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(245, 206);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 3;
            this.pbFoto.TabStop = false;
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.BackgroundColor = System.Drawing.Color.White;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columaMatricula,
            this.columnaMarca,
            this.columnaModelo,
            this.columnaPlazas,
            this.columnaAnio,
            this.columnaCoste});
            this.tabla.Location = new System.Drawing.Point(282, 138);
            this.tabla.MultiSelect = false;
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersVisible = false;
            this.tabla.RowTemplate.ReadOnly = true;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(693, 241);
            this.tabla.TabIndex = 4;
            this.tabla.SelectionChanged += new System.EventHandler(this.tabla_SelectionChanged);
            // 
            // columaMatricula
            // 
            this.columaMatricula.HeaderText = "Matrícula";
            this.columaMatricula.Name = "columaMatricula";
            this.columaMatricula.ReadOnly = true;
            this.columaMatricula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columaMatricula.Width = 80;
            // 
            // columnaMarca
            // 
            this.columnaMarca.HeaderText = "Marca";
            this.columnaMarca.Name = "columnaMarca";
            this.columnaMarca.ReadOnly = true;
            this.columnaMarca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnaMarca.Width = 180;
            // 
            // columnaModelo
            // 
            this.columnaModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnaModelo.HeaderText = "Modelo";
            this.columnaModelo.Name = "columnaModelo";
            this.columnaModelo.ReadOnly = true;
            this.columnaModelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // columnaPlazas
            // 
            this.columnaPlazas.HeaderText = "Plazas";
            this.columnaPlazas.Name = "columnaPlazas";
            this.columnaPlazas.ReadOnly = true;
            this.columnaPlazas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnaPlazas.Width = 60;
            // 
            // columnaAnio
            // 
            this.columnaAnio.HeaderText = "Año";
            this.columnaAnio.Name = "columnaAnio";
            this.columnaAnio.ReadOnly = true;
            this.columnaAnio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnaAnio.Width = 60;
            // 
            // columnaCoste
            // 
            this.columnaCoste.HeaderText = "Coste / Día";
            this.columnaCoste.Name = "columnaCoste";
            this.columnaCoste.ReadOnly = true;
            this.columnaCoste.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnaCoste.Width = 110;
            // 
            // labelPersonalizado1
            // 
            this.labelPersonalizado1.AutoSize = true;
            this.labelPersonalizado1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado1.Location = new System.Drawing.Point(9, 138);
            this.labelPersonalizado1.Name = "labelPersonalizado1";
            this.labelPersonalizado1.Size = new System.Drawing.Size(65, 16);
            this.labelPersonalizado1.TabIndex = 1;
            this.labelPersonalizado1.Text = "Matrícula:";
            // 
            // FormBusquedaVehiculosPorMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 396);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.labelPersonalizado1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBusquedaVehiculosPorMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler de Vehículos 1.0";
            this.Load += new System.EventHandler(this.FormBusquedaVehiculosPorMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Personalizados.LabelPersonalizado labelPersonalizado1;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn columaMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPlazas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCoste;
    }
}