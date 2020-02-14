namespace ArhcivosFormulario
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_parametros = new System.Windows.Forms.TextBox();
            this.txt_nombreArchivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmb_puertos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(76, 108);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parámetros";
            // 
            // txt_parametros
            // 
            this.txt_parametros.Location = new System.Drawing.Point(76, 72);
            this.txt_parametros.Name = "txt_parametros";
            this.txt_parametros.Size = new System.Drawing.Size(145, 20);
            this.txt_parametros.TabIndex = 2;
            // 
            // txt_nombreArchivo
            // 
            this.txt_nombreArchivo.Location = new System.Drawing.Point(76, 34);
            this.txt_nombreArchivo.Name = "txt_nombreArchivo";
            this.txt_nombreArchivo.Size = new System.Drawing.Size(145, 20);
            this.txt_nombreArchivo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // btn_abrir
            // 
            this.btn_abrir.Location = new System.Drawing.Point(181, 108);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(75, 23);
            this.btn_abrir.TabIndex = 0;
            this.btn_abrir.Text = "Abrir";
            this.btn_abrir.UseVisualStyleBackColor = true;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmb_puertos
            // 
            this.cmb_puertos.FormattingEnabled = true;
            this.cmb_puertos.Location = new System.Drawing.Point(316, 29);
            this.cmb_puertos.Name = "cmb_puertos";
            this.cmb_puertos.Size = new System.Drawing.Size(165, 21);
            this.cmb_puertos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 214);
            this.Controls.Add(this.cmb_puertos);
            this.Controls.Add(this.txt_nombreArchivo);
            this.Controls.Add(this.txt_parametros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.btn_guardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_parametros;
        private System.Windows.Forms.TextBox txt_nombreArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmb_puertos;
    }
}

