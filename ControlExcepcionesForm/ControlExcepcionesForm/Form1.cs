using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlExcepcionesForm
{
    public partial class Form1 : Form
    {

        private int indice;
        private Persona[] arreglopersonas;
        public int Indice
        {
            get
            {
                return indice;
            }
            set
            {
                if(value < 0  ||  value > 9)
                {
                    indice = 0;
                }
                else
                {
                    indice = value;
                }
            }

        }



        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtNombre.Text == ""|| txtTelefono.Text == ""|| txtCorreo.Text == "")
                {
                    // throw new ArgumentNullException();
                    string Fallo = "No dejes los campos vacíos";
                    throw new ApplicationException(Fallo);
                    
                }
                string telefono = txtTelefono.Text;
                for ( int i =0; i < telefono.Length; i ++)
                {
                   
                    if((int)telefono[i]<48 || (int)telefono[i]>57)
                    {
                        // throw new ApplicationException("Solo se pueden usar números");
                        throw new FormatException("Solo se pueden usar números en teléfono");
                    }
                }

                string correo = txtCorreo.Text;
                for(int i=0; i<correo.Length; i++)
                {
                    if(!correo.Contains("@"))
                    {
                        throw new FormatException("Correo no válido no hay arroba");


                    }

                    if(!correo.Contains("."))
                    {
                        throw new FormatException("Correo no válido no hay ningún punto");

                    }




                }


                arreglopersonas = new Persona[10];
                              //++indice: preincremento
                arreglopersonas[Indice++] = new Persona(txtNombre.Text, byte.Parse(txtEdad.Text), txtTelefono.Text, txtCorreo.Text);
                txtNombre.Text = "";
                txtEdad.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";


            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "Error de formato",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException error)
            {
                MessageBox.Show(error.Message, "No dejes celdas vacías", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch ( ApplicationException error  )
            {
                MessageBox.Show(error.Message);
            }

            catch
            {
                MessageBox.Show("Hubo un problema en el programa");
            }           
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            txtNombre.Text = arreglopersonas[Indice].Nombre.ToString();
            txtEdad.Text = arreglopersonas[Indice].Edad.ToString();
            txtTelefono.Text = arreglopersonas[Indice].Telefono;
            txtCorreo.Text = arreglopersonas[Indice].Correo;
            Indice++;
        }
    }
}
