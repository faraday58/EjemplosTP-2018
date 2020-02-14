using System;
using System.Drawing;
using System.Windows.Forms;

namespace HolaMundoWindows
{
    partial class FormularioBienvenida:Form
    {

        private Label lbNombre;
        private TextBox txtbNombre;
        private Button btnAceptar;

        public void IniciarComponentes()
        {
            //Asignando valores a los atributos
            this.ClientSize = new Size(300, 200);
            this.Name = "Formulario_Bienvenida";
            this.StartPosition = FormStartPosition.CenterScreen;

            //Asignación de valores a las propiedades de los atributos
            //contenidos en el Formalurio

            //Label lbNombre
            this.lbNombre = new Label();
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Text = "Nombre";
            this.lbNombre.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            this.lbNombre.TextAlign = ContentAlignment.MiddleCenter;
            this.lbNombre.Location = new Point(10, 20);
            this.lbNombre.Size = new Size(180, 35);

            this.btnAceptar = new Button();
            this.btnAceptar.Click += new EventHandler(Saludo);

            this.Controls.Add(lbNombre);

        }


    }
}
