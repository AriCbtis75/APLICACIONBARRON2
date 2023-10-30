using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APLICACIONBARRON2.formularios;

namespace APLICACIONBARRON2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)

        {

            if (textBoxUsuario.Text == string.Empty)
            {
                if (textBoxContraseña.Text == string.Empty)
                {
                    MessageBox.Show("El usuario o contraseña son incorrectos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (textBoxContraseña.Text == "1711")
                    {
                        MessageBox.Show("El usuario invalido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El usuario o contraseña son incorrectos", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                if (textBoxUsuario.Text == string.Empty)
                {
                    MessageBox.Show("La contraseña es incorrecta", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
                else
                {

                    if (textBoxUsuario.Text == "Ariadna" && textBoxContraseña.Text == "1711")
                    {
                        MessageBox.Show("Ingreso Correcto", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        FormaMenu menu = new FormaMenu();
                        menu.Show();
                        

                    }
                    else if (textBoxUsuario.Text != "Ariadna" && textBoxContraseña.Text == "1711")
                    {
                        MessageBox.Show("El usuario es incorrecto", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBoxUsuario.Text == "Ariadna" && textBoxContraseña.Text != "1711")
                    {
                        MessageBox.Show("La contraseña es incorrecta", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrar.Checked)
            {
                textBoxContraseña.PasswordChar = '\0';
            }
            else
            {
                textBoxContraseña.PasswordChar = '*';
            }
        }

        private void labelRegistro_Click(object sender, EventArgs e)
        {
            Hide();
            FormaRegistro registro = new FormaRegistro();
            registro.Show();

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void checkBoxMostrar_CheckStateChanged(object sender, EventArgs e)
        {

        }
    }
}
