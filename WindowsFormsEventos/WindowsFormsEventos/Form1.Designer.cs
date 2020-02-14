namespace WindowsFormsEventos
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
            this.btn_lanzar = new System.Windows.Forms.Button();
            this.listbox_objetos = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_lanzar
            // 
            this.btn_lanzar.Location = new System.Drawing.Point(204, 73);
            this.btn_lanzar.Name = "btn_lanzar";
            this.btn_lanzar.Size = new System.Drawing.Size(75, 23);
            this.btn_lanzar.TabIndex = 1;
            this.btn_lanzar.Text = "Lanzar";
            this.btn_lanzar.UseVisualStyleBackColor = true;
            this.btn_lanzar.Click += new System.EventHandler(this.btn_lanzar_Click);
            // 
            // listbox_objetos
            // 
            this.listbox_objetos.FormattingEnabled = true;
            this.listbox_objetos.Items.AddRange(new object[] {
            "Llaves",
            "Celular",
            "Otros"});
            this.listbox_objetos.Location = new System.Drawing.Point(36, 30);
            this.listbox_objetos.Name = "listbox_objetos";
            this.listbox_objetos.Size = new System.Drawing.Size(88, 95);
            this.listbox_objetos.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 234);
            this.Controls.Add(this.listbox_objetos);
            this.Controls.Add(this.btn_lanzar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_lanzar;
        private System.Windows.Forms.ListBox listbox_objetos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
    }
}

