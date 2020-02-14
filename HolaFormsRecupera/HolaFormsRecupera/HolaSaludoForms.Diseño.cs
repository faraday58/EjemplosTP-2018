using System;
using System.Drawing;
using System.Windows.Forms;

namespace HolaSaludoForms
{
    partial class HolaSaludoForms:Form
    {
        private Label etBienvenido;
        private TextBox txtNombre;
        private Button button1;
        private Button btnAceptar;

        public void IniciarComponent()
        {

            //Asignando valores a los atributos de nuestro formulario
            this.ClientSize = new Size(300, 200);
            this.Name = "Formulario_Bienvenida";
            this.Text = "Formulario de Bienvenida";
            this.StartPosition = FormStartPosition.CenterScreen;

            //Construcción o asignación de valores a los atributos contenidos en la ventana
            this.etBienvenido = new Label();
            this.etBienvenido.Name = "etBienvenido";
            this.etBienvenido.Text = "Bienvenido";
            this.etBienvenido.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            this.etBienvenido.TextAlign = ContentAlignment.MiddleCenter;
            this.etBienvenido.Location = new Point(10, 20);
            this.etBienvenido.Size = new Size(180, 35);

            //Construcción del Textbox

            this.txtNombre = new TextBox();
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Text = "Ingresa tu nombre";
            this.txtNombre.Font = new Font("Arial", 10, FontStyle.Italic);
            this.txtNombre.TextAlign = HorizontalAlignment.Left;
            this.txtNombre.Location = new Point(20, 70);
            this.txtNombre.Size = new Size(200, 20);

            //Construcción del boton
            this.btnAceptar = new Button();
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Font = new Font("Comic Sans", 10, FontStyle.Bold);
            this.btnAceptar.TextAlign = ContentAlignment.MiddleCenter;
            this.btnAceptar.Location = new Point(30, 100);
            this.btnAceptar.Size = new Size(100, 20);
            this.btnAceptar.Click += new EventHandler(btnAceptar_Click);

            this.Controls.Add(etBienvenido);
            this.Controls.Add(txtNombre);
            this.Controls.Add(btnAceptar);


        }

            }
}
