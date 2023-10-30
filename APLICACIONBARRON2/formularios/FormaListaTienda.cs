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
    public partial class FormaListaTienda : Form
    {
        public FormaListaTienda()
        {
            InitializeComponent();
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
                int codigo = Int32.Parse(textBoxCodigo.Text);
                int precio = Int32.Parse(textBoxPrecio.Text);


                DataGridViewRow renglon = (DataGridViewRow)dataGridViewProductos.Rows[0].Clone();

                renglon.Cells[0].Value = textBoxCodigo.Text;
                renglon.Cells[1].Value = textBoxProducto.Text;
                renglon.Cells[2].Value = textBoxPrecio.Text;
                renglon.Cells[3].Value = dateTimePicker1.Text;


                dataGridViewProductos.Rows.Add(renglon);
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

            if (!(dataGridViewProductos.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataGridViewProductos.Rows.Remove(dataGridViewProductos.CurrentRow);
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
            if (dataGridViewProductos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleciona un renglón", "Modificando Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                textBoxCodigo.Text = dataGridViewProductos.CurrentRow.Cells["Codigo"].Value.ToString();
                textBoxProducto.Text = dataGridViewProductos.CurrentRow.Cells["Producto"].Value.ToString();
                textBoxPrecio.Text = dataGridViewProductos.CurrentRow.Cells["Precio"].Value.ToString();
                dateTimePicker1.Text = dataGridViewProductos.CurrentRow.Cells["Fecha"].Value.ToString();


            }
        }
    }


}

