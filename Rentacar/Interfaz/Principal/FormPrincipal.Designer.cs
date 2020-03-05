namespace Rentacar.Interfaz.Principal
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.característicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVehículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorMatrículaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehículosAlquiladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoResumidoDeVehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDetalladoDeVehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeAlquileresPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeAlquileresPorVehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.vehículosToolStripMenuItem,
            this.característicasToolStripMenuItem,
            this.accesoriosToolStripMenuItem,
            this.marcasToolStripMenuItem});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // vehículosToolStripMenuItem
            // 
            this.vehículosToolStripMenuItem.Name = "vehículosToolStripMenuItem";
            this.vehículosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.vehículosToolStripMenuItem.Text = "Vehículos";
            this.vehículosToolStripMenuItem.Click += new System.EventHandler(this.vehículosToolStripMenuItem_Click);
            // 
            // característicasToolStripMenuItem
            // 
            this.característicasToolStripMenuItem.Name = "característicasToolStripMenuItem";
            this.característicasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.característicasToolStripMenuItem.Text = "Características";
            this.característicasToolStripMenuItem.Click += new System.EventHandler(this.característicasToolStripMenuItem_Click);
            // 
            // accesoriosToolStripMenuItem
            // 
            this.accesoriosToolStripMenuItem.Name = "accesoriosToolStripMenuItem";
            this.accesoriosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.accesoriosToolStripMenuItem.Text = "Accesorios";
            this.accesoriosToolStripMenuItem.Click += new System.EventHandler(this.accesoriosToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarClienteToolStripMenuItem,
            this.buscarVehículoToolStripMenuItem,
            this.vehículosAlquiladosToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // buscarVehículoToolStripMenuItem
            // 
            this.buscarVehículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPorMatrículaToolStripMenuItem,
            this.buscarPorFiltrosToolStripMenuItem});
            this.buscarVehículoToolStripMenuItem.Name = "buscarVehículoToolStripMenuItem";
            this.buscarVehículoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.buscarVehículoToolStripMenuItem.Text = "Buscar Vehículo";
            // 
            // buscarPorMatrículaToolStripMenuItem
            // 
            this.buscarPorMatrículaToolStripMenuItem.Name = "buscarPorMatrículaToolStripMenuItem";
            this.buscarPorMatrículaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.buscarPorMatrículaToolStripMenuItem.Text = "Buscar por matrícula";
            this.buscarPorMatrículaToolStripMenuItem.Click += new System.EventHandler(this.buscarPorMatrículaToolStripMenuItem_Click);
            // 
            // buscarPorFiltrosToolStripMenuItem
            // 
            this.buscarPorFiltrosToolStripMenuItem.Name = "buscarPorFiltrosToolStripMenuItem";
            this.buscarPorFiltrosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.buscarPorFiltrosToolStripMenuItem.Text = "Buscar por filtros";
            this.buscarPorFiltrosToolStripMenuItem.Click += new System.EventHandler(this.buscarPorFiltrosToolStripMenuItem_Click);
            // 
            // vehículosAlquiladosToolStripMenuItem
            // 
            this.vehículosAlquiladosToolStripMenuItem.Name = "vehículosAlquiladosToolStripMenuItem";
            this.vehículosAlquiladosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.vehículosAlquiladosToolStripMenuItem.Text = "Vehículos alquilados";
            this.vehículosAlquiladosToolStripMenuItem.Click += new System.EventHandler(this.vehículosAlquiladosToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeClientesToolStripMenuItem,
            this.listadoResumidoDeVehículosToolStripMenuItem,
            this.listadoDetalladoDeVehículosToolStripMenuItem,
            this.listadoDeAlquileresPorFechaToolStripMenuItem,
            this.listadoDeAlquileresPorVehículosToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de clientes";
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesToolStripMenuItem_Click);
            // 
            // listadoResumidoDeVehículosToolStripMenuItem
            // 
            this.listadoResumidoDeVehículosToolStripMenuItem.Name = "listadoResumidoDeVehículosToolStripMenuItem";
            this.listadoResumidoDeVehículosToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.listadoResumidoDeVehículosToolStripMenuItem.Text = "Listado resumido de vehículos";
            this.listadoResumidoDeVehículosToolStripMenuItem.Click += new System.EventHandler(this.listadoResumidoDeVehículosToolStripMenuItem_Click);
            // 
            // listadoDetalladoDeVehículosToolStripMenuItem
            // 
            this.listadoDetalladoDeVehículosToolStripMenuItem.Name = "listadoDetalladoDeVehículosToolStripMenuItem";
            this.listadoDetalladoDeVehículosToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.listadoDetalladoDeVehículosToolStripMenuItem.Text = "Listado detallado de vehículos";
            this.listadoDetalladoDeVehículosToolStripMenuItem.Click += new System.EventHandler(this.listadoDetalladoDeVehículosToolStripMenuItem_Click);
            // 
            // listadoDeAlquileresPorFechaToolStripMenuItem
            // 
            this.listadoDeAlquileresPorFechaToolStripMenuItem.Name = "listadoDeAlquileresPorFechaToolStripMenuItem";
            this.listadoDeAlquileresPorFechaToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.listadoDeAlquileresPorFechaToolStripMenuItem.Text = "Listado de alquileres por fecha";
            this.listadoDeAlquileresPorFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeAlquileresPorFechaToolStripMenuItem_Click);
            // 
            // listadoDeAlquileresPorVehículosToolStripMenuItem
            // 
            this.listadoDeAlquileresPorVehículosToolStripMenuItem.Name = "listadoDeAlquileresPorVehículosToolStripMenuItem";
            this.listadoDeAlquileresPorVehículosToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.listadoDeAlquileresPorVehículosToolStripMenuItem.Text = "Listado de alquileres por vehículos";
            this.listadoDeAlquileresPorVehículosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeAlquileresPorVehículosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 545);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "prueba2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 584);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler de Vehículos 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem característicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarVehículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorMatrículaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorFiltrosToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem vehículosAlquiladosToolStripMenuItem;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoResumidoDeVehículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDetalladoDeVehículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeAlquileresPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeAlquileresPorVehículosToolStripMenuItem;

    }
}