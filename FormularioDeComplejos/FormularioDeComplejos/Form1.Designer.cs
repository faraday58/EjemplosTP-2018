namespace FormularioDeComplejos
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
            this.txtreal1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtimaginario1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtreal2 = new System.Windows.Forms.TextBox();
            this.txtimaginario2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.etSuma = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.etMultiplicacion = new System.Windows.Forms.Label();
            this.btnmulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce ambos números complejos";
            // 
            // txtreal1
            // 
            this.txtreal1.Location = new System.Drawing.Point(30, 82);
            this.txtreal1.Name = "txtreal1";
            this.txtreal1.Size = new System.Drawing.Size(44, 20);
            this.txtreal1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "+";
            // 
            // txtimaginario1
            // 
            this.txtimaginario1.Location = new System.Drawing.Point(121, 82);
            this.txtimaginario1.Name = "txtimaginario1";
            this.txtimaginario1.Size = new System.Drawing.Size(44, 20);
            this.txtimaginario1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "+";
            // 
            // txtreal2
            // 
            this.txtreal2.Location = new System.Drawing.Point(30, 153);
            this.txtreal2.Name = "txtreal2";
            this.txtreal2.Size = new System.Drawing.Size(44, 20);
            this.txtreal2.TabIndex = 1;
            // 
            // txtimaginario2
            // 
            this.txtimaginario2.Location = new System.Drawing.Point(121, 153);
            this.txtimaginario2.Name = "txtimaginario2";
            this.txtimaginario2.Size = new System.Drawing.Size(44, 20);
            this.txtimaginario2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Segundo complejo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Primer complejo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "i";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(171, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "i";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Suma";
            // 
            // etSuma
            // 
            this.etSuma.AutoSize = true;
            this.etSuma.Location = new System.Drawing.Point(289, 90);
            this.etSuma.Name = "etSuma";
            this.etSuma.Size = new System.Drawing.Size(55, 13);
            this.etSuma.TabIndex = 0;
            this.etSuma.Text = "Resultado";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(66, 200);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(76, 41);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Multiplicacion";
            // 
            // etMultiplicacion
            // 
            this.etMultiplicacion.AutoSize = true;
            this.etMultiplicacion.Location = new System.Drawing.Point(313, 153);
            this.etMultiplicacion.Name = "etMultiplicacion";
            this.etMultiplicacion.Size = new System.Drawing.Size(55, 13);
            this.etMultiplicacion.TabIndex = 0;
            this.etMultiplicacion.Text = "Resultado";
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(211, 200);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(122, 41);
            this.btnmulti.TabIndex = 2;
            this.btnmulti.Text = "Multiplicacion";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 298);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtimaginario2);
            this.Controls.Add(this.txtimaginario1);
            this.Controls.Add(this.txtreal2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtreal1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.etSuma);
            this.Controls.Add(this.etMultiplicacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtreal1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtimaginario1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtreal2;
        private System.Windows.Forms.TextBox txtimaginario2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label etSuma;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label etMultiplicacion;
        private System.Windows.Forms.Button btnmulti;
        
    }
}

