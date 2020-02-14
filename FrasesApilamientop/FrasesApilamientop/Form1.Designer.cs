namespace FrasesApilamientop
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_frase = new System.Windows.Forms.TextBox();
            this.lst_push = new System.Windows.Forms.ListBox();
            this.lst_pop = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pUSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa Frase";
            // 
            // txt_frase
            // 
            this.txt_frase.Location = new System.Drawing.Point(122, 27);
            this.txt_frase.Name = "txt_frase";
            this.txt_frase.Size = new System.Drawing.Size(204, 20);
            this.txt_frase.TabIndex = 1;
            // 
            // lst_push
            // 
            this.lst_push.FormattingEnabled = true;
            this.lst_push.Location = new System.Drawing.Point(48, 96);
            this.lst_push.Name = "lst_push";
            this.lst_push.Size = new System.Drawing.Size(115, 108);
            this.lst_push.TabIndex = 2;
            // 
            // lst_pop
            // 
            this.lst_pop.FormattingEnabled = true;
            this.lst_pop.Location = new System.Drawing.Point(218, 96);
            this.lst_pop.Name = "lst_pop";
            this.lst_pop.Size = new System.Drawing.Size(120, 108);
            this.lst_pop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PUSH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "POP";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pUSHToolStripMenuItem,
            this.pOPToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // pUSHToolStripMenuItem
            // 
            this.pUSHToolStripMenuItem.Name = "pUSHToolStripMenuItem";
            this.pUSHToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.pUSHToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pUSHToolStripMenuItem.Text = "PUSH";
            this.pUSHToolStripMenuItem.Click += new System.EventHandler(this.pUSHToolStripMenuItem_Click);
            // 
            // pOPToolStripMenuItem
            // 
            this.pOPToolStripMenuItem.Name = "pOPToolStripMenuItem";
            this.pOPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pOPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pOPToolStripMenuItem.Text = "POP";
            this.pOPToolStripMenuItem.Click += new System.EventHandler(this.pOPToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_pop);
            this.Controls.Add(this.lst_push);
            this.Controls.Add(this.txt_frase);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_frase;
        private System.Windows.Forms.ListBox lst_push;
        private System.Windows.Forms.ListBox lst_pop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pUSHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOPToolStripMenuItem;
    }
}

