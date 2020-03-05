namespace Rentacar.Interfaz.Operaciones.Vehiculos
{
    partial class FormBusquedaVehiculosPorFiltros
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.cbModelos = new System.Windows.Forms.ComboBox();
            this.cbMarcas = new System.Windows.Forms.ComboBox();
            this.checkBoxModelo = new System.Windows.Forms.CheckBox();
            this.checkboxMarca = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labelPersonalizado3 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.tbVeces = new System.Windows.Forms.TextBox();
            this.labelPersonalizado2 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.cbCaracteristicas = new System.Windows.Forms.ComboBox();
            this.rbAlquiladosVeces = new System.Windows.Forms.RadioButton();
            this.rbAlquiladosGroupBy = new System.Windows.Forms.RadioButton();
            this.rbAlquiladoDistinct = new System.Windows.Forms.RadioButton();
            this.labelPersonalizado1 = new Rentacar.Interfaz.Personalizados.LabelPersonalizado();
            this.rbMarcaModelo = new System.Windows.Forms.RadioButton();
            this.rbCaracteristicas = new System.Windows.Forms.RadioButton();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.columaMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPlazas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCoste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentacar.Properties.Resources.BusquedaVehiculosFiltros;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAplicarFiltro);
            this.groupBox1.Controls.Add(this.cbModelos);
            this.groupBox1.Controls.Add(this.cbMarcas);
            this.groupBox1.Controls.Add(this.checkBoxModelo);
            this.groupBox1.Controls.Add(this.checkboxMarca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Enabled = false;
            this.btnAplicarFiltro.Location = new System.Drawing.Point(391, 44);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(120, 23);
            this.btnAplicarFiltro.TabIndex = 4;
            this.btnAplicarFiltro.Text = "Aplicar filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // cbModelos
            // 
            this.cbModelos.Enabled = false;
            this.cbModelos.FormattingEnabled = true;
            this.cbModelos.Location = new System.Drawing.Point(104, 58);
            this.cbModelos.Name = "cbModelos";
            this.cbModelos.Size = new System.Drawing.Size(197, 24);
            this.cbModelos.TabIndex = 3;
            // 
            // cbMarcas
            // 
            this.cbMarcas.Enabled = false;
            this.cbMarcas.FormattingEnabled = true;
            this.cbMarcas.Location = new System.Drawing.Point(104, 28);
            this.cbMarcas.Name = "cbMarcas";
            this.cbMarcas.Size = new System.Drawing.Size(197, 24);
            this.cbMarcas.TabIndex = 2;
            this.cbMarcas.SelectionChangeCommitted += new System.EventHandler(this.cbMarcas_SelectionChangeCommitted);
            // 
            // checkBoxModelo
            // 
            this.checkBoxModelo.AutoSize = true;
            this.checkBoxModelo.Enabled = false;
            this.checkBoxModelo.Location = new System.Drawing.Point(16, 58);
            this.checkBoxModelo.Name = "checkBoxModelo";
            this.checkBoxModelo.Size = new System.Drawing.Size(73, 20);
            this.checkBoxModelo.TabIndex = 1;
            this.checkBoxModelo.Text = "Modelo";
            this.checkBoxModelo.UseVisualStyleBackColor = true;
            this.checkBoxModelo.CheckedChanged += new System.EventHandler(this.cbModelo_CheckedChanged);
            // 
            // checkboxMarca
            // 
            this.checkboxMarca.AutoSize = true;
            this.checkboxMarca.Location = new System.Drawing.Point(16, 30);
            this.checkboxMarca.Name = "checkboxMarca";
            this.checkboxMarca.Size = new System.Drawing.Size(65, 20);
            this.checkboxMarca.TabIndex = 0;
            this.checkboxMarca.Text = "Marca";
            this.checkboxMarca.UseVisualStyleBackColor = true;
            this.checkboxMarca.CheckedChanged += new System.EventHandler(this.cbMarca_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.labelPersonalizado3);
            this.groupBox2.Controls.Add(this.tbVeces);
            this.groupBox2.Controls.Add(this.labelPersonalizado2);
            this.groupBox2.Controls.Add(this.tbModelo);
            this.groupBox2.Controls.Add(this.tbMarca);
            this.groupBox2.Controls.Add(this.cbCaracteristicas);
            this.groupBox2.Controls.Add(this.rbAlquiladosVeces);
            this.groupBox2.Controls.Add(this.rbAlquiladosGroupBy);
            this.groupBox2.Controls.Add(this.rbAlquiladoDistinct);
            this.groupBox2.Controls.Add(this.labelPersonalizado1);
            this.groupBox2.Controls.Add(this.rbMarcaModelo);
            this.groupBox2.Controls.Add(this.rbCaracteristicas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(13, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 179);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas avanzadas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(410, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 61);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelPersonalizado3
            // 
            this.labelPersonalizado3.AutoSize = true;
            this.labelPersonalizado3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado3.Location = new System.Drawing.Point(326, 141);
            this.labelPersonalizado3.Name = "labelPersonalizado3";
            this.labelPersonalizado3.Size = new System.Drawing.Size(40, 16);
            this.labelPersonalizado3.TabIndex = 11;
            this.labelPersonalizado3.Text = "veces";
            // 
            // tbVeces
            // 
            this.tbVeces.Location = new System.Drawing.Point(220, 137);
            this.tbVeces.Name = "tbVeces";
            this.tbVeces.Size = new System.Drawing.Size(100, 22);
            this.tbVeces.TabIndex = 10;
            // 
            // labelPersonalizado2
            // 
            this.labelPersonalizado2.AutoSize = true;
            this.labelPersonalizado2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado2.Location = new System.Drawing.Point(533, 64);
            this.labelPersonalizado2.Name = "labelPersonalizado2";
            this.labelPersonalizado2.Size = new System.Drawing.Size(58, 16);
            this.labelPersonalizado2.TabIndex = 9;
            this.labelPersonalizado2.Text = "( Aprox.)";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(372, 60);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(155, 22);
            this.tbModelo.TabIndex = 8;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(147, 60);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(149, 22);
            this.tbMarca.TabIndex = 7;
            // 
            // cbCaracteristicas
            // 
            this.cbCaracteristicas.FormattingEnabled = true;
            this.cbCaracteristicas.Location = new System.Drawing.Point(171, 33);
            this.cbCaracteristicas.Name = "cbCaracteristicas";
            this.cbCaracteristicas.Size = new System.Drawing.Size(419, 24);
            this.cbCaracteristicas.TabIndex = 6;
            // 
            // rbAlquiladosVeces
            // 
            this.rbAlquiladosVeces.AutoSize = true;
            this.rbAlquiladosVeces.Location = new System.Drawing.Point(15, 138);
            this.rbAlquiladosVeces.Name = "rbAlquiladosVeces";
            this.rbAlquiladosVeces.Size = new System.Drawing.Size(199, 20);
            this.rbAlquiladosVeces.TabIndex = 5;
            this.rbAlquiladosVeces.TabStop = true;
            this.rbAlquiladosVeces.Text = "Vehículos alquilados más de";
            this.rbAlquiladosVeces.UseVisualStyleBackColor = true;
            this.rbAlquiladosVeces.Click += new System.EventHandler(this.TodosLosRadioBox_OnCLick);
            // 
            // rbAlquiladosGroupBy
            // 
            this.rbAlquiladosGroupBy.AutoSize = true;
            this.rbAlquiladosGroupBy.Location = new System.Drawing.Point(15, 112);
            this.rbAlquiladosGroupBy.Name = "rbAlquiladosGroupBy";
            this.rbAlquiladosGroupBy.Size = new System.Drawing.Size(329, 20);
            this.rbAlquiladosGroupBy.TabIndex = 4;
            this.rbAlquiladosGroupBy.TabStop = true;
            this.rbAlquiladosGroupBy.Text = "Vehículos alquilados una vez (usando GROUP BY)";
            this.rbAlquiladosGroupBy.UseVisualStyleBackColor = true;
            this.rbAlquiladosGroupBy.Click += new System.EventHandler(this.TodosLosRadioBox_OnCLick);
            // 
            // rbAlquiladoDistinct
            // 
            this.rbAlquiladoDistinct.AutoSize = true;
            this.rbAlquiladoDistinct.Location = new System.Drawing.Point(15, 86);
            this.rbAlquiladoDistinct.Name = "rbAlquiladoDistinct";
            this.rbAlquiladoDistinct.Size = new System.Drawing.Size(321, 20);
            this.rbAlquiladoDistinct.TabIndex = 3;
            this.rbAlquiladoDistinct.TabStop = true;
            this.rbAlquiladoDistinct.Text = "Vehículos alquilados una vez (usando DISTINCT)";
            this.rbAlquiladoDistinct.UseVisualStyleBackColor = true;
            this.rbAlquiladoDistinct.Click += new System.EventHandler(this.TodosLosRadioBox_OnCLick);
            // 
            // labelPersonalizado1
            // 
            this.labelPersonalizado1.AutoSize = true;
            this.labelPersonalizado1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.labelPersonalizado1.Location = new System.Drawing.Point(302, 64);
            this.labelPersonalizado1.Name = "labelPersonalizado1";
            this.labelPersonalizado1.Size = new System.Drawing.Size(64, 16);
            this.labelPersonalizado1.TabIndex = 2;
            this.labelPersonalizado1.Text = "Y modelo";
            // 
            // rbMarcaModelo
            // 
            this.rbMarcaModelo.AutoSize = true;
            this.rbMarcaModelo.Location = new System.Drawing.Point(15, 60);
            this.rbMarcaModelo.Name = "rbMarcaModelo";
            this.rbMarcaModelo.Size = new System.Drawing.Size(126, 20);
            this.rbMarcaModelo.TabIndex = 1;
            this.rbMarcaModelo.TabStop = true;
            this.rbMarcaModelo.Text = "Vehiculos marca";
            this.rbMarcaModelo.UseVisualStyleBackColor = true;
            this.rbMarcaModelo.Click += new System.EventHandler(this.TodosLosRadioBox_OnCLick);
            // 
            // rbCaracteristicas
            // 
            this.rbCaracteristicas.AutoSize = true;
            this.rbCaracteristicas.Location = new System.Drawing.Point(15, 34);
            this.rbCaracteristicas.Name = "rbCaracteristicas";
            this.rbCaracteristicas.Size = new System.Drawing.Size(150, 20);
            this.rbCaracteristicas.TabIndex = 0;
            this.rbCaracteristicas.TabStop = true;
            this.rbCaracteristicas.Text = "Vehículos que tienen";
            this.rbCaracteristicas.UseVisualStyleBackColor = true;
            this.rbCaracteristicas.Click += new System.EventHandler(this.TodosLosRadioBox_OnCLick);
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
            this.tabla.Location = new System.Drawing.Point(13, 431);
            this.tabla.MultiSelect = false;
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersVisible = false;
            this.tabla.RowTemplate.ReadOnly = true;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(606, 200);
            this.tabla.TabIndex = 5;
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
            // FormBusquedaVehiculosPorFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 647);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBusquedaVehiculosPorFiltros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler de Vehículos 1.0";
            this.Load += new System.EventHandler(this.FormBusquedaVehiculosPorFiltros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbModelos;
        private System.Windows.Forms.ComboBox cbMarcas;
        private System.Windows.Forms.CheckBox checkBoxModelo;
        private System.Windows.Forms.CheckBox checkboxMarca;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private Personalizados.LabelPersonalizado labelPersonalizado3;
        private System.Windows.Forms.TextBox tbVeces;
        private Personalizados.LabelPersonalizado labelPersonalizado2;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.ComboBox cbCaracteristicas;
        private System.Windows.Forms.RadioButton rbAlquiladosVeces;
        private System.Windows.Forms.RadioButton rbAlquiladosGroupBy;
        private System.Windows.Forms.RadioButton rbAlquiladoDistinct;
        private Personalizados.LabelPersonalizado labelPersonalizado1;
        private System.Windows.Forms.RadioButton rbMarcaModelo;
        private System.Windows.Forms.RadioButton rbCaracteristicas;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn columaMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPlazas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCoste;
    }
}