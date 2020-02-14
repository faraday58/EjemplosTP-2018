namespace Graficar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.control = new System.Windows.Forms.Panel();
            this.buttonGo = new System.Windows.Forms.Button();
            this.incremento = new System.Windows.Forms.TextBox();
            this.longitud = new System.Windows.Forms.TextBox();
            this.angulo = new System.Windows.Forms.TextBox();
            this.lineas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.Panel();
            this.control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineas)).BeginInit();
            this.SuspendLayout();
            // 
            // control
            // 
            this.control.BackColor = System.Drawing.SystemColors.ControlDark;
            this.control.Controls.Add(this.buttonGo);
            this.control.Controls.Add(this.incremento);
            this.control.Controls.Add(this.longitud);
            this.control.Controls.Add(this.angulo);
            this.control.Controls.Add(this.lineas);
            this.control.Controls.Add(this.label4);
            this.control.Controls.Add(this.label3);
            this.control.Controls.Add(this.label2);
            this.control.Controls.Add(this.label1);
            this.control.Dock = System.Windows.Forms.DockStyle.Top;
            this.control.Location = new System.Drawing.Point(0, 0);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(679, 38);
            this.control.TabIndex = 0;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(558, 4);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(44, 23);
            this.buttonGo.TabIndex = 8;
            this.buttonGo.Text = "GO!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // incremento
            // 
            this.incremento.Location = new System.Drawing.Point(497, 5);
            this.incremento.Name = "incremento";
            this.incremento.Size = new System.Drawing.Size(38, 20);
            this.incremento.TabIndex = 7;
            this.incremento.Text = "1";
            // 
            // longitud
            // 
            this.longitud.Location = new System.Drawing.Point(338, 5);
            this.longitud.Name = "longitud";
            this.longitud.Size = new System.Drawing.Size(40, 20);
            this.longitud.TabIndex = 6;
            this.longitud.Text = "5";
            // 
            // angulo
            // 
            this.angulo.Location = new System.Drawing.Point(216, 5);
            this.angulo.Name = "angulo";
            this.angulo.Size = new System.Drawing.Size(36, 20);
            this.angulo.TabIndex = 5;
            this.angulo.Text = "90";
            // 
            // lineas
            // 
            this.lineas.Location = new System.Drawing.Point(91, 5);
            this.lineas.Name = "lineas";
            this.lineas.Size = new System.Drawing.Size(47, 20);
            this.lineas.TabIndex = 4;
            this.lineas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(394, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Incretement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(268, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lenght";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(154, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "# lineas";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Info;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 38);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(679, 351);
            this.canvas.TabIndex = 1;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 389);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.control);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Rayas";
            this.control.ResumeLayout(false);
            this.control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel control;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox longitud;
        private System.Windows.Forms.TextBox angulo;
        private System.Windows.Forms.NumericUpDown lineas;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox incremento;
    }
}

