namespace WindowsEventos
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
            this.btn_presiona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_presiona
            // 
            this.btn_presiona.Location = new System.Drawing.Point(177, 123);
            this.btn_presiona.Name = "btn_presiona";
            this.btn_presiona.Size = new System.Drawing.Size(241, 62);
            this.btn_presiona.TabIndex = 0;
            this.btn_presiona.Text = "Presiona";
            this.btn_presiona.UseVisualStyleBackColor = true;
            this.btn_presiona.Click += new System.EventHandler(this.btn_presiona_Click);
            this.btn_presiona.MouseLeave += new System.EventHandler(this.btn_presiona_MouseLeave);
            this.btn_presiona.MouseHover += new System.EventHandler(this.btn_presiona_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 261);
            this.Controls.Add(this.btn_presiona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_presiona;
    }
}

