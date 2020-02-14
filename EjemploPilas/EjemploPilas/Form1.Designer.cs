namespace EjemploPilas
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
            this.lst_eliminados_pop = new System.Windows.Forms.ListBox();
            this.cmb_elementos_push = new System.Windows.Forms.ComboBox();
            this.txt_elemento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_eliminados_pop
            // 
            this.lst_eliminados_pop.FormattingEnabled = true;
            this.lst_eliminados_pop.Location = new System.Drawing.Point(209, 133);
            this.lst_eliminados_pop.Name = "lst_eliminados_pop";
            this.lst_eliminados_pop.Size = new System.Drawing.Size(120, 95);
            this.lst_eliminados_pop.TabIndex = 0;
            // 
            // cmb_elementos_push
            // 
            this.cmb_elementos_push.FormattingEnabled = true;
            this.cmb_elementos_push.Location = new System.Drawing.Point(208, 81);
            this.cmb_elementos_push.Name = "cmb_elementos_push";
            this.cmb_elementos_push.Size = new System.Drawing.Size(121, 21);
            this.cmb_elementos_push.TabIndex = 1;
            this.cmb_elementos_push.SelectedIndexChanged += new System.EventHandler(this.cmb_elementos_push_SelectedIndexChanged);
            this.cmb_elementos_push.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmb_elementos_push_MouseDoubleClick);
            // 
            // txt_elemento
            // 
            this.txt_elemento.Location = new System.Drawing.Point(209, 24);
            this.txt_elemento.Name = "txt_elemento";
            this.txt_elemento.Size = new System.Drawing.Size(100, 20);
            this.txt_elemento.TabIndex = 2;
            this.txt_elemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_elemento_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduce elemento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_elemento);
            this.Controls.Add(this.cmb_elementos_push);
            this.Controls.Add(this.lst_eliminados_pop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_eliminados_pop;
        private System.Windows.Forms.ComboBox cmb_elementos_push;
        private System.Windows.Forms.TextBox txt_elemento;
        private System.Windows.Forms.Label label1;
    }
}

