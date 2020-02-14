namespace Fracciones
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
            this.btnCalcula = new System.Windows.Forms.Button();
            this.etoperador = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdenom1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtdenom2 = new System.Windows.Forms.TextBox();
            this.rdbsuma = new System.Windows.Forms.RadioButton();
            this.rdbMulti = new System.Windows.Forms.RadioButton();
            this.rdbResta = new System.Windows.Forms.RadioButton();
            this.rdbDiv = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.etRestultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(319, 98);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 0;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // etoperador
            // 
            this.etoperador.AutoSize = true;
            this.etoperador.Location = new System.Drawing.Point(95, 89);
            this.etoperador.Name = "etoperador";
            this.etoperador.Size = new System.Drawing.Size(49, 13);
            this.etoperador.TabIndex = 1;
            this.etoperador.Text = "operador";
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(48, 66);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(51, 20);
            this.txt_num1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "______";
            // 
            // txtdenom1
            // 
            this.txtdenom1.Location = new System.Drawing.Point(48, 105);
            this.txtdenom1.Name = "txtdenom1";
            this.txtdenom1.Size = new System.Drawing.Size(51, 20);
            this.txtdenom1.TabIndex = 2;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(138, 66);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(51, 20);
            this.txtnum2.TabIndex = 2;
            // 
            // txtdenom2
            // 
            this.txtdenom2.Location = new System.Drawing.Point(138, 105);
            this.txtdenom2.Name = "txtdenom2";
            this.txtdenom2.Size = new System.Drawing.Size(51, 20);
            this.txtdenom2.TabIndex = 2;
            // 
            // rdbsuma
            // 
            this.rdbsuma.AutoSize = true;
            this.rdbsuma.Location = new System.Drawing.Point(14, 12);
            this.rdbsuma.Name = "rdbsuma";
            this.rdbsuma.Size = new System.Drawing.Size(50, 17);
            this.rdbsuma.TabIndex = 3;
            this.rdbsuma.TabStop = true;
            this.rdbsuma.Text = "suma";
            this.rdbsuma.UseVisualStyleBackColor = true;
            this.rdbsuma.CheckedChanged += new System.EventHandler(this.rdbsuma_CheckedChanged);
            // 
            // rdbMulti
            // 
            this.rdbMulti.AutoSize = true;
            this.rdbMulti.Location = new System.Drawing.Point(186, 12);
            this.rdbMulti.Name = "rdbMulti";
            this.rdbMulti.Size = new System.Drawing.Size(88, 17);
            this.rdbMulti.TabIndex = 3;
            this.rdbMulti.TabStop = true;
            this.rdbMulti.Text = "multiplicación";
            this.rdbMulti.UseVisualStyleBackColor = true;
            this.rdbMulti.CheckedChanged += new System.EventHandler(this.rdbMulti_CheckedChanged);
            // 
            // rdbResta
            // 
            this.rdbResta.AutoSize = true;
            this.rdbResta.Location = new System.Drawing.Point(95, 12);
            this.rdbResta.Name = "rdbResta";
            this.rdbResta.Size = new System.Drawing.Size(48, 17);
            this.rdbResta.TabIndex = 3;
            this.rdbResta.TabStop = true;
            this.rdbResta.Text = "resta";
            this.rdbResta.UseVisualStyleBackColor = true;
            this.rdbResta.CheckedChanged += new System.EventHandler(this.rdbResta_CheckedChanged);
            // 
            // rdbDiv
            // 
            this.rdbDiv.AutoSize = true;
            this.rdbDiv.Location = new System.Drawing.Point(277, 12);
            this.rdbDiv.Name = "rdbDiv";
            this.rdbDiv.Size = new System.Drawing.Size(60, 17);
            this.rdbDiv.TabIndex = 3;
            this.rdbDiv.TabStop = true;
            this.rdbDiv.Text = "división";
            this.rdbDiv.UseVisualStyleBackColor = true;
            this.rdbDiv.CheckedChanged += new System.EventHandler(this.rdbDiv_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "______";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultado";
            // 
            // etRestultado
            // 
            this.etRestultado.AutoSize = true;
            this.etRestultado.Location = new System.Drawing.Point(227, 98);
            this.etRestultado.Name = "etRestultado";
            this.etRestultado.Size = new System.Drawing.Size(0, 13);
            this.etRestultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.Controls.Add(this.etRestultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbResta);
            this.Controls.Add(this.rdbDiv);
            this.Controls.Add(this.rdbMulti);
            this.Controls.Add(this.rdbsuma);
            this.Controls.Add(this.txtdenom2);
            this.Controls.Add(this.txtdenom1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.etoperador);
            this.Controls.Add(this.btnCalcula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label etoperador;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdenom1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtdenom2;
        private System.Windows.Forms.RadioButton rdbsuma;
        private System.Windows.Forms.RadioButton rdbMulti;
        private System.Windows.Forms.RadioButton rdbResta;
        private System.Windows.Forms.RadioButton rdbDiv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label etRestultado;
    }
}

