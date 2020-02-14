namespace PalindromoArduino
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
            this.txt_palindromo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_puertos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_palindromo
            // 
            this.txt_palindromo.Location = new System.Drawing.Point(126, 88);
            this.txt_palindromo.Name = "txt_palindromo";
            this.txt_palindromo.Size = new System.Drawing.Size(218, 20);
            this.txt_palindromo.TabIndex = 0;
            this.txt_palindromo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_palindromo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa palabra palíndromo";
            // 
            // cmb_puertos
            // 
            this.cmb_puertos.FormattingEnabled = true;
            this.cmb_puertos.Location = new System.Drawing.Point(12, 12);
            this.cmb_puertos.Name = "cmb_puertos";
            this.cmb_puertos.Size = new System.Drawing.Size(87, 21);
            this.cmb_puertos.TabIndex = 2;
            this.cmb_puertos.SelectionChangeCommitted += new System.EventHandler(this.cmb_puertos_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 130);
            this.Controls.Add(this.cmb_puertos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_palindromo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_palindromo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_puertos;
    }
}

