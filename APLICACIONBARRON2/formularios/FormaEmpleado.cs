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
    public partial class FormaEmpleado : Form
    {
        public FormaEmpleado()
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
                int numT = Int32.Parse(textBoxNumeroT.Text);
                int numA = Int32.Parse(textBoxNumeroA.Text);


                DataGridViewRow renglon = (DataGridViewRow)dataGridViewEmpleados.Rows[0].Clone();

                renglon.Cells[0].Value = textBoxNombre.Text;
                renglon.Cells[1].Value = textBoxApellidoP.Text;
                renglon.Cells[2].Value = textBoxApellidoM.Text;
                renglon.Cells[3].Value = textBoxINE.Text;
                renglon.Cells[4].Value = textBoxDomicilio.Text;
                renglon.Cells[5].Value = textBoxNumeroT.Text;
                renglon.Cells[6].Value = textBoxNumeroA.Text;
                renglon.Cells[7].Value = textBoxCargo.Text;
                renglon.Cells[8].Value = comboBoxContrato.Text;
                renglon.Cells[9].Value = comboBoxTurno.Text;

                dataGridViewEmpleados.Rows.Add(renglon);
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

            if (!(dataGridViewEmpleados.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataGridViewEmpleados.Rows.Remove(dataGridViewEmpleados.CurrentRow);
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
            if (dataGridViewEmpleados.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleciona un renglón", "Modificando Datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                textBoxNombre.Text = dataGridViewEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                textBoxApellidoP.Text = dataGridViewEmpleados.CurrentRow.Cells["ApellidoPaterno"].Value.ToString();
                textBoxApellidoM.Text = dataGridViewEmpleados.CurrentRow.Cells["ApellidoMaterno"].Value.ToString();
                textBoxINE.Text = dataGridViewEmpleados.CurrentRow.Cells["INE"].Value.ToString();
                textBoxDomicilio.Text = dataGridViewEmpleados.CurrentRow.Cells["Domicilio"].Value.ToString();
                textBoxNumeroT.Text = dataGridViewEmpleados.CurrentRow.Cells["NoTelefono"].Value.ToString();
                textBoxNumeroA.Text = dataGridViewEmpleados.CurrentRow.Cells["NoAfiliacion"].Value.ToString();
                textBoxCargo.Text = dataGridViewEmpleados.CurrentRow.Cells["cargoEmpresa"].Value.ToString();
                comboBoxContrato.Text = dataGridViewEmpleados.CurrentRow.Cells["Contrato"].Value.ToString();
                comboBoxTurno.Text = dataGridViewEmpleados.CurrentRow.Cells["Turno"].Value.ToString();
            }

        }
    }
}
