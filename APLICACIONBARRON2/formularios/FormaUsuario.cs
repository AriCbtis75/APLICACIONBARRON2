using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APLICACIONBARRON2.formularios
{
    public partial class FormaUsuario : Form
    {
        public FormaUsuario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Hide();
            FormaMenu menu = new FormaMenu();
            menu.Show();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int numT = Int32.Parse(textBoxNumero.Text);
                int edad = Int32.Parse(textBoxEdad.Text);


                DataGridViewRow renglon = (DataGridViewRow)dataGridViewUsuario.Rows[0].Clone();

                renglon.Cells[0].Value = textBoxNombre.Text;
                renglon.Cells[1].Value = textBoxApellido.Text;
                renglon.Cells[2].Value = textBoxNombreU.Text;
                renglon.Cells[3].Value = textBoxCorreo.Text;
                renglon.Cells[4].Value = textBoxContraseña.Text;
                renglon.Cells[5].Value = dateTimePicker1.Text;
                renglon.Cells[6].Value = textBoxNumero.Text;
                renglon.Cells[7].Value = comboBoxGenero.Text;
                renglon.Cells[8].Value = textBoxEdad.Text;

                dataGridViewUsuario.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desear eliminar el registro?";
            string titulo = "Eliminando el registro";

            if (!(dataGridViewUsuario.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataGridViewUsuario.Rows.Remove(dataGridViewUsuario.CurrentRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleciona un renglón", "Eliminado Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuario.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleciona un renglón", "Modificando Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                textBoxNombre.Text = dataGridViewUsuario.CurrentRow.Cells["Nombre"].Value.ToString();
                textBoxApellido.Text = dataGridViewUsuario.CurrentRow.Cells["Apellido"].Value.ToString();
                textBoxNombreU.Text = dataGridViewUsuario.CurrentRow.Cells["nombreUsuario"].Value.ToString();
                textBoxCorreo.Text = dataGridViewUsuario.CurrentRow.Cells["Correo"].Value.ToString();
                textBoxContraseña.Text = dataGridViewUsuario.CurrentRow.Cells["Contraseña"].Value.ToString();
                dateTimePicker1.Text = dataGridViewUsuario.CurrentRow.Cells["Fecha"].Value.ToString();
                textBoxNumero.Text = dataGridViewUsuario.CurrentRow.Cells["Celular"].Value.ToString();
                comboBoxGenero.Text = dataGridViewUsuario.CurrentRow.Cells["Genero"].Value.ToString();
                textBoxEdad.Text = dataGridViewUsuario.CurrentRow.Cells["Edad"].Value.ToString();
            }

        }
    }
}
