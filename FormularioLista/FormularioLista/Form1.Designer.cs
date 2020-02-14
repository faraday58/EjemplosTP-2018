namespace FormularioLista
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
            this.txt_servicio = new System.Windows.Forms.TextBox();
            this.cmb_servicio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio";
            // 
            // txt_servicio
            // 
            this.txt_servicio.Location = new System.Drawing.Point(90, 58);
            this.txt_servicio.Name = "txt_servicio";
            this.txt_servicio.Size = new System.Drawing.Size(100, 20);
            this.txt_servicio.TabIndex = 1;
            this.txt_servicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_servicio_KeyPress);
            // 
            // cmb_servicio
            // 
            this.cmb_servicio.FormattingEnabled = true;
            this.cmb_servicio.Location = new System.Drawing.Point(313, 57);
            this.cmb_servicio.Name = "cmb_servicio";
            this.cmb_servicio.Size = new System.Drawing.Size(176, 21);
            this.cmb_servicio.TabIndex = 2;
            this.cmb_servicio.SelectedIndexChanged += new System.EventHandler(this.cmb_servicio_SelectedIndexChanged);
            this.cmb_servicio.SelectionChangeCommitted += new System.EventHandler(this.cmb_servicio_SelectionChangeCommitted);
            this.cmb_servicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_servicio_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione un servicio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 164);
            this.Controls.Add(this.cmb_servicio);
            this.Controls.Add(this.txt_servicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_servicio;
        private System.Windows.Forms.ComboBox cmb_servicio;
        private System.Windows.Forms.Label label2;
    }
}

