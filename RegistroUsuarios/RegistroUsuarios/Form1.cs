using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegistroUsuarios
{
    public partial class Form1 : Form
    {
        private Usuario [,] arregloUsuario;
        private int contGrupo;
        private int contUsuario;

        public int ContGrupo
        {
            get
            {
                return contGrupo;
            }
            set
            {
                if( value > 1)
                {
                    contGrupo = 0;
                }
                else
                {
                    contGrupo = value;
                }
            }
        }

        public int ContUsuario
        {
            get
            {
                return contUsuario;
            }
            set
            {
                if(  value <0 || value > 1  )
                {
                    contUsuario = 0;
                    ContGrupo++;
                }
                else
                {
                    contUsuario = value;
                }
            }
        }


        public Form1()
        {
            // Son dos grupos por 4 usuarios
            arregloUsuario = new Usuario[2, 2];
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < txtbEdad.Text.Length; i++)
                {
                    if ((char)txtbEdad.Text[i] < 48 || (char)txtbEdad.Text[i] > 57)
                    {
                        string errorEdad = "Edad";
                        throw new FormatException(errorEdad);
                    }
                }

                for (int i = 0; i < txtbLada.Text.Length; i++)
                {
                    if ((char)txtbLada.Text[i] < 48 || (char)txtbLada.Text[i] > 57)
                    {
                        string errorLada = "Lada";
                        throw new FormatException(errorLada);
                    }
                }
                for (int i = 0; i < txtbTelefono.Text.Length; i++)
                {
                    if ((char)txtbTelefono.Text[i] < 48 || (char)txtbTelefono.Text[i] > 57)
                    {
                        string errorTelefono = "Telefono";
                        throw new FormatException(errorTelefono);
                    }
                }

                if (!txtbCorreo.Text.Contains("@") && !txtbCorreo.Text.Contains("."))//! negado
                {
                    string errorCorreo = "Correo no válido.";
                    throw new ApplicationException(errorCorreo);
                }

                arregloUsuario[ContGrupo, ContUsuario++] = new Usuario(txtbNombre.Text, byte.Parse(txtbEdad.Text), txtbLada.Text, txtbTelefono.Text, txtbCorreo.Text);


                MessageBox.Show("Datos ingresados correctamente");
                txtbNombre.Text = "";
                txtbEdad.Text = "";
                txtbLada.Text = "";
                txtbTelefono.Text = "";
                txtbCorreo.Text = "";

            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message + " Debe ser un número");
            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message);
            }
            

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if(arregloUsuario[ContGrupo,ContUsuario] != null)
            {
                
                txtbNombre.Text = arregloUsuario[ContGrupo, ContUsuario].Nombre;
                txtbEdad.Text = arregloUsuario[ContGrupo, ContUsuario].Edad.ToString();
                txtbLada.Text = arregloUsuario[ContGrupo, ContUsuario].Lada;
                txtbTelefono.Text = arregloUsuario[ContGrupo, ContUsuario].Telefono;
                txtbCorreo.Text = arregloUsuario[ContGrupo, ContUsuario].Correo;

                ContUsuario++;
            }
            
        }
    }
}
