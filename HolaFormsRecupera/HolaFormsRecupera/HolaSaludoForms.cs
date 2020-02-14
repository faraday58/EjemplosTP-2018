using System;
using System.Windows.Forms;

//Este archivo contiene los métodos de la clase


namespace HolaSaludoForms
{
    partial class HolaSaludoForms : Form
    {
        private Button btncambiar;

        public HolaSaludoForms()
         {
            IniciarComponent();
         }

        private void InitializeComponent()
        {
            this.btncambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncambiar
            // 
            this.btncambiar.Location = new System.Drawing.Point(176, 160);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(75, 23);
            this.btncambiar.TabIndex = 0;
            this.btncambiar.Text = "Cambiar";
            this.btncambiar.UseVisualStyleBackColor = true;
            this.btncambiar.Click += new System.EventHandler(this.btncambiar_Click);
            // 
            // HolaSaludoForms
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btncambiar);
            this.Name = "HolaSaludoForms";
            this.ResumeLayout(false);

        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            etBienvenido.Text = "Cambio a tu nombre" + txtNombre.Text;
        }
    }
}
