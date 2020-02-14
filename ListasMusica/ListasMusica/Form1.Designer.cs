namespace ListasMusica
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
            this.lst_datosmusica = new System.Windows.Forms.ListBox();
            this.txt_artista = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_album = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_datosmusica
            // 
            this.lst_datosmusica.FormattingEnabled = true;
            this.lst_datosmusica.Location = new System.Drawing.Point(251, 42);
            this.lst_datosmusica.Name = "lst_datosmusica";
            this.lst_datosmusica.Size = new System.Drawing.Size(228, 160);
            this.lst_datosmusica.TabIndex = 0;
            this.lst_datosmusica.SelectedIndexChanged += new System.EventHandler(this.lst_datosmusica_SelectedIndexChanged);
            // 
            // txt_artista
            // 
            this.txt_artista.Location = new System.Drawing.Point(87, 42);
            this.txt_artista.Name = "txt_artista";
            this.txt_artista.Size = new System.Drawing.Size(100, 20);
            this.txt_artista.TabIndex = 1;
            this.txt_artista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_artista_MouseDoubleClick);
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(87, 77);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(100, 20);
            this.txt_titulo.TabIndex = 1;
            // 
            // txt_album
            // 
            this.txt_album.Location = new System.Drawing.Point(87, 119);
            this.txt_album.Name = "txt_album";
            this.txt_album.Size = new System.Drawing.Size(100, 20);
            this.txt_album.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Álbum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Título";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_album);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.txt_artista);
            this.Controls.Add(this.lst_datosmusica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_datosmusica;
        private System.Windows.Forms.TextBox txt_artista;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_album;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

