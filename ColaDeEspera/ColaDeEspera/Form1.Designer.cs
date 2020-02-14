namespace ColaDeEspera
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmb_seccion = new System.Windows.Forms.ComboBox();
            this.dgv_listaespera = new System.Windows.Forms.DataGridView();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_espera = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaespera)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sección";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(120, 26);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // cmb_seccion
            // 
            this.cmb_seccion.FormattingEnabled = true;
            this.cmb_seccion.Location = new System.Drawing.Point(120, 59);
            this.cmb_seccion.Name = "cmb_seccion";
            this.cmb_seccion.Size = new System.Drawing.Size(121, 21);
            this.cmb_seccion.TabIndex = 3;
            // 
            // dgv_listaespera
            // 
            this.dgv_listaespera.AllowUserToAddRows = false;
            this.dgv_listaespera.AllowUserToDeleteRows = false;
            this.dgv_listaespera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaespera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_cliente,
            this.seccion,
            this.turno});
            this.dgv_listaespera.Location = new System.Drawing.Point(120, 99);
            this.dgv_listaespera.Name = "dgv_listaespera";
            this.dgv_listaespera.ReadOnly = true;
            this.dgv_listaespera.Size = new System.Drawing.Size(341, 150);
            this.dgv_listaespera.TabIndex = 4;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.Frozen = true;
            this.nombre_cliente.HeaderText = "Nombre del Cliente";
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.ReadOnly = true;
            // 
            // seccion
            // 
            this.seccion.Frozen = true;
            this.seccion.HeaderText = "Sección a pasar";
            this.seccion.Name = "seccion";
            this.seccion.ReadOnly = true;
            // 
            // turno
            // 
            this.turno.Frozen = true;
            this.turno.HeaderText = "Turno";
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
            // 
            // tiempo_espera
            // 
            this.tiempo_espera.Interval = 4000;
            this.tiempo_espera.Tick += new System.EventHandler(this.tiempo_espera_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atenderToolStripMenuItem,
            this.detenerServicioToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // atenderToolStripMenuItem
            // 
            this.atenderToolStripMenuItem.Name = "atenderToolStripMenuItem";
            this.atenderToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.atenderToolStripMenuItem.Text = "Atender";
            this.atenderToolStripMenuItem.Click += new System.EventHandler(this.atenderToolStripMenuItem_Click);
            // 
            // detenerServicioToolStripMenuItem
            // 
            this.detenerServicioToolStripMenuItem.Name = "detenerServicioToolStripMenuItem";
            this.detenerServicioToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.detenerServicioToolStripMenuItem.Text = "Detener Servicio";
            this.detenerServicioToolStripMenuItem.Click += new System.EventHandler(this.detenerServicioToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 346);
            this.Controls.Add(this.dgv_listaespera);
            this.Controls.Add(this.cmb_seccion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaespera)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cmb_seccion;
        private System.Windows.Forms.DataGridView dgv_listaespera;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.Timer tiempo_espera;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerServicioToolStripMenuItem;
    }
}

