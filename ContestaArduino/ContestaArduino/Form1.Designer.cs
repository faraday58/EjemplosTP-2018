namespace ContestaArduino
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
            this.btn_envio = new System.Windows.Forms.Button();
            this.txt_envio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_envio
            // 
            this.btn_envio.Location = new System.Drawing.Point(90, 138);
            this.btn_envio.Name = "btn_envio";
            this.btn_envio.Size = new System.Drawing.Size(75, 23);
            this.btn_envio.TabIndex = 0;
            this.btn_envio.Text = "Enviar";
            this.btn_envio.UseVisualStyleBackColor = true;
            this.btn_envio.Click += new System.EventHandler(this.btn_envio_Click);
            // 
            // txt_envio
            // 
            this.txt_envio.Location = new System.Drawing.Point(90, 95);
            this.txt_envio.Name = "txt_envio";
            this.txt_envio.Size = new System.Drawing.Size(100, 20);
            this.txt_envio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contesta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_envio);
            this.Controls.Add(this.btn_envio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_envio;
        private System.Windows.Forms.TextBox txt_envio;
        private System.Windows.Forms.Label label1;
    }
}

