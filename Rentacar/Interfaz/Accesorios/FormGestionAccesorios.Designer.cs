namespace Rentacar.Interfaz.Accesorios
{
    partial class FormGestionAccesorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionAccesorios));
            this.tabla = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelPersonalizado2 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.labelPersonalizado1 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeColumns = false;
            this.tabla.AllowUserToResizeRows = false;
            this.tabla.BackgroundColor = System.Drawing.Color.White;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.ColumnHeadersVisible = false;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaId,
            this.columnaNombre,
            this.columnaPrecio});
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.Location = new System.Drawing.Point(12, 77);
            this.tabla.MultiSelect = false;
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabla.RowHeadersVisible = false;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(313, 150);
            this.tabla.TabIndex = 1;
            this.tabla.SelectionChanged += new System.EventHandler(this.tabla_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.tbPrecio);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.labelPersonalizado2);
            this.groupBox1.Controls.Add(this.labelPersonalizado1);
            this.groupBox1.Location = new System.Drawing.Point(13, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = global::Rentacar.Properties.Resources.Eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(211, 90);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "     Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = global::Rentacar.Properties.Resources.Modificar;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(110, 90);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 30);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "      Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Image = global::Rentacar.Properties.Resources.Añadir;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(10, 90);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 30);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "      Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(228, 45);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(73, 20);
            this.tbPrecio.TabIndex = 3;
            this.tbPrecio.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(10, 45);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(186, 20);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(313, 49);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelPersonalizado2
            // 
            this.labelPersonalizado2.AutoSize = true;
            this.labelPersonalizado2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado2.Location = new System.Drawing.Point(225, 26);
            this.labelPersonalizado2.Name = "labelPersonalizado2";
            this.labelPersonalizado2.Size = new System.Drawing.Size(47, 16);
            this.labelPersonalizado2.TabIndex = 1;
            this.labelPersonalizado2.Text = "Precio:";
            // 
            // labelPersonalizado1
            // 
            this.labelPersonalizado1.AutoSize = true;
            this.labelPersonalizado1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado1.Location = new System.Drawing.Point(7, 26);
            this.labelPersonalizado1.Name = "labelPersonalizado1";
            this.labelPersonalizado1.Size = new System.Drawing.Size(68, 16);
            this.labelPersonalizado1.TabIndex = 0;
            this.labelPersonalizado1.Text = "Accesorio:";
            // 
            // columnaId
            // 
            this.columnaId.HeaderText = "Id";
            this.columnaId.Name = "columnaId";
            this.columnaId.ReadOnly = true;
            this.columnaId.Visible = false;
            // 
            // columnaNombre
            // 
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            this.columnaNombre.ReadOnly = true;
            this.columnaNombre.Width = 250;
            // 
            // columnaPrecio
            // 
            this.columnaPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnaPrecio.HeaderText = "Precio";
            this.columnaPrecio.Name = "columnaPrecio";
            this.columnaPrecio.ReadOnly = true;
            this.columnaPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormGestionAccesorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGestionAccesorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler de vehículos 1.0";
            this.Load += new System.EventHandler(this.FormGestionAccesorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbNombre;
        private Personalizados.LabelPersonalizado labelPersonalizado2;
        private Personalizados.LabelPersonalizado labelPersonalizado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPrecio;
    }
}