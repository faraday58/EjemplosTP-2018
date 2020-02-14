﻿namespace Sprites1
{
    partial class FormEscenario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Link = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Chest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chest)).BeginInit();
            this.SuspendLayout();
            // 
            // Link
            // 
            this.Link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Link.BackColor = System.Drawing.Color.Transparent;
            this.Link.Image = global::Sprites1.Properties.Resources.link7;
            this.Link.Location = new System.Drawing.Point(226, 322);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(73, 69);
            this.Link.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Link.TabIndex = 0;
            this.Link.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Chest
            // 
            this.Chest.BackColor = System.Drawing.Color.Transparent;
            this.Chest.Image = global::Sprites1.Properties.Resources.chest;
            this.Chest.Location = new System.Drawing.Point(226, 97);
            this.Chest.Name = "Chest";
            this.Chest.Size = new System.Drawing.Size(58, 40);
            this.Chest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chest.TabIndex = 1;
            this.Chest.TabStop = false;
            // 
            // FormEscenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sprites1.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Chest);
            this.Controls.Add(this.Link);
            this.DoubleBuffered = true;
            this.Name = "FormEscenario";
            this.Text = "Ejemplo de Sprites";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1Escenario_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormEscenario_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Link;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Chest;

    }
}

